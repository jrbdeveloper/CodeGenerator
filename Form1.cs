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
        private Arguments _arguments;
        private Generator _generator;
        
        private const string DATA_EXTENSION = "Data.cs";
        private const string DOMAIN_EXTENSION = "Domain.cs";
        private const string VIEW_MODEL_EXTENSION = "ViewModel.cs";
        private const string CONTROLLER_EXTENSION = "Controller.cs";
        private const string VIEW_EXTENSION = ".cshtml";
        private const string SCRIPT_EXTENSION = ".module.js";

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

        public Generator Generator
        {
            get
            {
                if (_generator == null)
                {
                    _generator = new Generator(Arguments);
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
                btnGenerate.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateObjects();
            GenerateViews();
            GenerateScripts();

            lblStatus.Text = "Complete - Do not forget to include the new assets in your solution.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateObjects()
        {
            Generator.GenerateInterface(new GeneratorCriteria
            {
                Template = new DataContract(Arguments),
                Project = cbDataContracts,
                FolderPath = tbDataContracts.Text,
                Extension = DATA_EXTENSION,
            });

            Generator.GenerateInterface(new GeneratorCriteria
            {
                Template = new DomainContract(Arguments),
                Project = cbDomainContracts,
                FolderPath = tbDomainContracts.Text,
                Extension = DOMAIN_EXTENSION,
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new ViewModel(Arguments),
                Project = cbViewModels,
                FolderPath = tbViewModels.Text,
                Extension = VIEW_MODEL_EXTENSION,
            });
            
            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new DataModel(Arguments),
                Project = cbDataModels,
                FolderPath = tbDataModels.Text,
                Extension = DATA_EXTENSION
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new DomainModel(Arguments),
                Project = cbDomainModels,
                FolderPath = tbDomainModels.Text,
                Extension = DOMAIN_EXTENSION
            });

            Generator.GenerateObject(new GeneratorCriteria
            {
                Template = new Controller(Arguments),
                Project = cbControllers,
                FolderPath = tbControllers.Text,
                Extension = CONTROLLER_EXTENSION
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
                        Template = new CreateView(Arguments),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Create,
                        Extension = VIEW_EXTENSION,
                    });
                }

                if (chkDetails.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new DetailsView(Arguments),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Details,
                        Extension = VIEW_EXTENSION,
                    });
                }

                if (chkEdit.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new EditView(Arguments),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Edit,
                        Extension = VIEW_EXTENSION,
                    });
                }

                if (chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Templates.UI.Views.ListView(Arguments),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.List,
                        Extension = VIEW_EXTENSION,
                    });
                }

                if (!chkCreate.Checked && !chkDetails.Checked && !chkEdit.Checked && !chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Templates.UI.Views.View(Arguments),
                        Project = cbViews,
                        FolderPath = tbViews.Text,
                        ViewType = ViewType.Specific,
                        Extension = VIEW_EXTENSION,
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
                        Template = new CreateScript(Arguments),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Create,
                        Extension = SCRIPT_EXTENSION,
                    });
                }

                if (chkDetails.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new DetailsScript(Arguments),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Details,
                        Extension = SCRIPT_EXTENSION,
                    });
                }

                if (chkEdit.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new EditScript(Arguments),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Edit,
                        Extension = SCRIPT_EXTENSION,
                    });
                }

                if (chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new ListScript(Arguments),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.List,
                        Extension = SCRIPT_EXTENSION,
                    });
                }

                if (!chkCreate.Checked && !chkDetails.Checked && !chkEdit.Checked && !chkList.Checked)
                {
                    Generator.GenerateAsset(new GeneratorCriteria
                    {
                        Template = new Script(Arguments),
                        Project = cbScriptModules,
                        FolderPath = tbScriptModules.Text,
                        ViewType = ViewType.Specific,
                        Extension = SCRIPT_EXTENSION,
                    });
                }
            }            
        }

        private void ParseSolution()
        {
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