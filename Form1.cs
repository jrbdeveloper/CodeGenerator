using CodeGenerator.Classes;
using CodeGenerator.Templates.Core.Contracts.Data;
using CodeGenerator.Templates.Core.Contracts.Domain;
using CodeGenerator.Templates.Core.ViewModel;
using CodeGenerator.Templates.Data;
using CodeGenerator.Templates.Domain;
using CodeGenerator.Templates.UI.Controller;
using System.Windows.Forms;
using System;
using Onion.SolutionParser.Parser;
using System.Collections.Generic;
using CodeGenerator.Templates.UI.Scripts.Modules;
using System.IO;

namespace CodeGenerator
{
    public partial class CodeGenerator : Form
    {
        private Arguments _arguments;
        private const string INTERFACE_PREFIX = "I";
        private const string DATA_EXTENSION = "Data.cs";
        private const string DOMAIN_EXTENSION = "Domain.cs";
        private const string VIEW_MODEL_EXTENSION = "ViewModel.cs";
        private const string CONTROLLER_EXTENSION = "Controller.cs";
        private const string SCRIPT_EXTENSION = ".js";

        public Arguments Arguments
        {
            get
            {
                if (_arguments == null)
                {
                    _arguments = GetArguments();
                }

                return _arguments;
            }

            set { _arguments = value; }
        }

        public CodeGenerator()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            if (string.IsNullOrEmpty(tbSolutionPath.Text)) {
                lblStatus.Text = "Error - Please enter a Solution Path";
            } else if (string.IsNullOrEmpty(tbSolutionName.Text)) {
                lblStatus.Text = "Error - Please enter a Solution Name";
            } else if (string.IsNullOrEmpty(tbVerticleName.Text)) {
                lblStatus.Text = "Error - Please enter a Verticle Name";
            } else {
                var solution = SolutionParser.Parse(Arguments.SolutionPath + "\\" + Arguments.SolutionName + ".sln");
                var solutionProjects = solution.Projects;
                var projects = new List<Project>() { new Project() };

                foreach (var project in solutionProjects)
                {
                    projects.Add(new Project
                    {
                        Guid = project.Guid,
                        Name = project.Name,
                        Path = project.Path
                    });
                }

                cbDataContracts.BindingContext = new BindingContext();
                cbDataContracts.DataSource = projects;

                cbDomainContracts.BindingContext = new BindingContext();
                cbDomainContracts.DataSource = projects;

                cbViewModels.BindingContext = new BindingContext();
                cbViewModels.DataSource = projects;

                cbDataModels.BindingContext = new BindingContext();
                cbDataModels.DataSource = projects;

                cbDomainModels.BindingContext = new BindingContext();
                cbDomainModels.DataSource = projects;

                cbControllers.BindingContext = new BindingContext();
                cbControllers.DataSource = projects;

                cbScriptModules.BindingContext = new BindingContext();
                cbScriptModules.DataSource = projects;

                cbViews.BindingContext = new BindingContext();
                cbViews.DataSource = projects;

                lblStatus.Text = "Continue by setting your configuration settings.";
                btnGenerate.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateCoreAssets();
            GenerateDataModel();
            GenerateDomainModel();
            GenerateController();
            GenerateView();
            GenerateScript();

            lblStatus.Text = "Complete - Do not forget to include the new assets in your solution.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCoreAssets()
        {
            GenerateDataContract();
            GenerateDomainContract();
            GenerateViewModel();
        }

        private void GenerateDataContract()
        {
            if (cbDataContracts.SelectedValue != null)
            {
                var template = new DataContract(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbDataContracts.SelectedValue + "\\";
                var fileName = INTERFACE_PREFIX + Arguments.VerticleName + DATA_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbDataContracts.Text)) ? tbDataContracts.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }

        private void GenerateDomainContract()
        {
            if (cbDomainContracts.SelectedValue != null)
            {
                var template = new DomainContract(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbDomainContracts.SelectedValue + "\\";
                var fileName = INTERFACE_PREFIX + Arguments.VerticleName + DOMAIN_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbDomainContracts.Text)) ? tbDomainContracts.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }

        private void GenerateViewModel()
        {
            if (cbViewModels.SelectedValue != null)
            {
                var template = new ViewModel(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbViewModels.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + VIEW_MODEL_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbViewModels.Text)) ? tbViewModels.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }
        
        private void GenerateDataModel()
        {
            if (cbDataModels.SelectedValue != null)
            {
                var template = new DataModel(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbDataModels.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + DATA_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbDataModels.Text)) ? tbDataModels.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }

        private void GenerateDomainModel()
        {
            if (cbDomainModels.SelectedValue != null)
            {
                var template = new DomainModel(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbDomainModels.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + DOMAIN_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbDomainModels.Text)) ? tbDomainModels.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }

        private void GenerateController()
        {
            if (cbControllers.SelectedValue != null)
            {
                var template = new Controller(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbControllers.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + CONTROLLER_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbControllers.Text)) ? tbControllers.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }            
        }

        private void GenerateView()
        {
            if (cbViews.SelectedValue != null)
            {
                var viewBuilder = new ViewBuilder();
                var chkbxList = new List<CheckBox>() { chkCreate, chkDetails, chkEdit, chkList };
                var fullPath = Arguments.SolutionPath + "\\" + cbViews.SelectedValue + "\\";
                fullPath += (!string.IsNullOrEmpty(tbViews.Text)) ? tbViews.Text + "\\" + Arguments.VerticleName + "\\" : string.Empty;

                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }

                viewBuilder.AddCreateView(chkCreate, fullPath, Arguments);
                viewBuilder.AddDetailsView(chkDetails, fullPath, Arguments);
                viewBuilder.AddEditView(chkEdit, fullPath, Arguments);
                viewBuilder.AddListView(chkList, fullPath, Arguments);
                viewBuilder.AddSpecificView(chkbxList, fullPath, Arguments);
            }            
        }

        private void GenerateScript()
        {
            if (cbScriptModules.SelectedValue != null)
            {
                var template = new Script(Arguments);
                var fullPath = Arguments.SolutionPath + "\\" + cbScriptModules.SelectedValue + "\\";
                var fileName = Arguments.VerticleName + SCRIPT_EXTENSION;

                fullPath += (!string.IsNullOrEmpty(tbScriptModules.Text)) ? tbScriptModules.Text + "\\" : string.Empty;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
            
        }

        private Arguments GetArguments()
        {
            var arguments = new Arguments
            {
                SolutionPath = tbSolutionPath.Text,
                SolutionName = tbSolutionName.Text,
                VerticleName = tbVerticleName.Text
            };

            return arguments;
        }
    }
}