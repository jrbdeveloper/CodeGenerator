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
using CodeGenerator.Templates.UI.Views;
using CodeGenerator.Templates.UI.Scripts;

namespace CodeGenerator
{
    public partial class CodeGen : Form
    {
        private Generator _generator;
        
        private const string DATA_EXTENSION = "Data.cs";
        private const string DOMAIN_EXTENSION = "Domain.cs";
        private const string VIEW_MODEL_EXTENSION = "ViewModel.cs";
        private const string CONTROLLER_EXTENSION = "Controller.cs";
        private const string VIEW_EXTENSION = ".cshtml";
        private const string SCRIPT_EXTENSION = ".module.js";

        public Generator Generator
        {
            get
            {
                if (_generator == null)
                {
                    _generator = new Generator();
                }

                return _generator;
            }

            set { _generator = value; }
        }

        public CodeGen()
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
                ParseSolution();

                lblStatus.Text = "Continue by setting your configuration settings.";
                MessageBox.Show("Ready - Review the status field.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGenerate.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateObjects();
            GenerateViews();
            GenerateScripts();
            ShowMessage();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateObjects()
        {
            Generator.GenerateInterface(new GeneratorCriteria
            {
                Template = new DataContract(GetArguments(cbDataContracts, tbDataContracts)),
                Project = cbDataContracts,
                FolderPath = tbDataContracts.Text,
                Extension = DATA_EXTENSION,
                Arguments = GetArguments(cbDataContracts, tbDataContracts),
                ReGenCheck = chkReGenDataContract
            });

            Generator.GenerateInterface(new GeneratorCriteria
            {
                Template = new DomainContract(GetArguments(cbDomainContracts, tbDomainContracts)),
                Project = cbDomainContracts,
                FolderPath = tbDomainContracts.Text,
                Extension = DOMAIN_EXTENSION,
                Arguments = GetArguments(cbDomainContracts, tbDomainContracts),
                ReGenCheck = chkReGenDomainContract
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new ViewModel(GetArguments(cbViewModels, tbViewModels)),
                Project = cbViewModels,
                FolderPath = tbViewModels.Text,
                Extension = VIEW_MODEL_EXTENSION,
                Arguments = GetArguments(cbViewModels, tbViewModels),
                ReGenCheck = chkReGenViewModel
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new DataModel(GetArguments(cbDataModels, tbDataModels)),
                Project = cbDataModels,
                FolderPath = tbDataModels.Text,
                Extension = DATA_EXTENSION,
                Arguments = GetArguments(cbDataModels, tbDataModels),
                ReGenCheck = chkReGenDataModel
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new DomainModel(GetArguments(cbDomainModels, tbDomainModels)),
                Project = cbDomainModels,
                FolderPath = tbDomainModels.Text,
                Extension = DOMAIN_EXTENSION,
                Arguments = GetArguments(cbDomainModels, tbDomainModels),
                ReGenCheck = chkReGenDomainModel
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new Controller(GetArguments(cbControllers, tbControllers)),
                Project = cbControllers,
                FolderPath = tbControllers.Text,
                Extension = CONTROLLER_EXTENSION,
                Arguments = GetArguments(cbControllers, tbControllers),
                ReGenCheck = chkReGenController
            });
        }

        private void GenerateViews()
        {
            if (cbViews.SelectedValue != null)
            {
                if (chkCreate.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new CreateView(GetArguments(cbViews, tbViews)),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Create,
                        Extension = VIEW_EXTENSION,
                        Arguments = GetArguments(cbViews, tbViews),
                        ReGenCheck = chkReGenViews
                    });
                }

                if (chkDetails.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new DetailsView(GetArguments(cbViews, tbViews)),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Details,
                        Extension = VIEW_EXTENSION,
                        Arguments = GetArguments(cbViews, tbViews),
                        ReGenCheck = chkReGenViews
                    });
                }

                if (chkEdit.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new EditView(GetArguments(cbViews, tbViews)),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Edit,
                        Extension = VIEW_EXTENSION,
                        Arguments = GetArguments(cbViews, tbViews),
                        ReGenCheck = chkReGenViews
                    });
                }

                if (chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Templates.UI.Views.ListView(GetArguments(cbViews, tbViews)),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.List,
                        Extension = VIEW_EXTENSION,
                        Arguments = GetArguments(cbViews, tbViews),
                        ReGenCheck = chkReGenViews
                    });
                }

                if (!chkCreate.Checked && !chkDetails.Checked && !chkEdit.Checked && !chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Templates.UI.Views.View(GetArguments(cbViews, tbViews)),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Specific,
                        Extension = VIEW_EXTENSION,
                        Arguments = GetArguments(cbViews, tbViews),
                        ReGenCheck = chkReGenViews
                    });
                }
            }
        }

        private void GenerateScripts()
        {
            if (cbScriptModules.SelectedValue != null)
            {
                if (chkCreate.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new CreateScript(GetArguments(cbScriptModules, tbScriptModules)),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Create,
                        Extension = SCRIPT_EXTENSION,
                        Arguments = GetArguments(cbScriptModules, tbScriptModules),
                        ReGenCheck = chkReGenScripts
                    });
                }

                if (chkDetails.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new DetailsScript(GetArguments(cbScriptModules, tbScriptModules)),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Details,
                        Extension = SCRIPT_EXTENSION,
                        Arguments = GetArguments(cbScriptModules, tbScriptModules),
                        ReGenCheck = chkReGenScripts
                    });
                }

                if (chkEdit.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new EditScript(GetArguments(cbScriptModules, tbScriptModules)),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Edit,
                        Extension = SCRIPT_EXTENSION,
                        Arguments = GetArguments(cbScriptModules, tbScriptModules),
                        ReGenCheck = chkReGenScripts
                    });
                }

                if (chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new ListScript(GetArguments(cbScriptModules, tbScriptModules)),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.List,
                        Extension = SCRIPT_EXTENSION,
                        Arguments = GetArguments(cbScriptModules, tbScriptModules),
                        ReGenCheck = chkReGenScripts
                    });
                }

                if (!chkCreate.Checked && !chkDetails.Checked && !chkEdit.Checked && !chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Script(GetArguments(cbScriptModules, tbScriptModules)),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Specific,
                        Extension = SCRIPT_EXTENSION,
                        Arguments = GetArguments(cbScriptModules, tbScriptModules),
                        ReGenCheck = chkReGenScripts
                    });
                }
            }            
        }

        private void ParseSolution()
        {
            var args = GetArguments(null, null);
            var solution = SolutionParser.Parse(args.SolutionPath + "\\" + args.SolutionName + ".sln");
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
        }

        private Arguments GetArguments(ComboBox project, TextBox folders)
        {
            var arguments = new Arguments
            {
                SolutionPath = tbSolutionPath.Text,
                SolutionName = tbSolutionName.Text,
                VerticleName = tbVerticleName.Text,
                Project = (project != null) ? project.Text : string.Empty,
                Folders = (folders != null) ? folders.Text : string.Empty,
                DataContracts = GetNamespace(cbDataContracts.Text, tbDataContracts.Text),
                DomainContracts = GetNamespace(cbDomainContracts.Text, tbDomainContracts.Text),
                ViewModels = GetNamespace(cbViewModels.Text, tbViewModels.Text)
            };

            return arguments;
        }

        private string GetNamespace(string prefix, string sufix)
        {
            sufix = (!string.IsNullOrEmpty(sufix))
                ? "." + sufix.Replace("\\", ".")
                : string.Empty;

            return prefix + sufix;
        }

        private void ShowMessage()
        {
            lblStatus.Text = "";

            if (!string.IsNullOrEmpty(Generator.Error))
            {
                lblStatus.Text = Generator.Error;
                MessageBox.Show("Error - Review the status field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Generator.Error = string.Empty;
            }
            else
            {
                lblStatus.Text = "Complete - Do not forget to include the new assets in your solution.";
                MessageBox.Show("Success - Review the status field.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}