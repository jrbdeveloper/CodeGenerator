namespace CodeGenerator
{
    partial class CodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.tbVerticleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSolutionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSolutionPath = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDomainContracts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDataContracts = new System.Windows.Forms.ComboBox();
            this.tbDataContracts = new System.Windows.Forms.TextBox();
            this.cbDomainContracts = new System.Windows.Forms.ComboBox();
            this.cbViewModels = new System.Windows.Forms.ComboBox();
            this.tbViewModels = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDataModels = new System.Windows.Forms.ComboBox();
            this.cbDomainModels = new System.Windows.Forms.ComboBox();
            this.tbDataModels = new System.Windows.Forms.TextBox();
            this.tbDomainModels = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbControllers = new System.Windows.Forms.ComboBox();
            this.tbControllers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbScriptModules = new System.Windows.Forms.ComboBox();
            this.tbScriptModules = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbViews = new System.Windows.Forms.ComboBox();
            this.tbViews = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.chkCreate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verticle Name:";
            // 
            // tbVerticleName
            // 
            this.tbVerticleName.Location = new System.Drawing.Point(91, 91);
            this.tbVerticleName.Name = "tbVerticleName";
            this.tbVerticleName.Size = new System.Drawing.Size(516, 20);
            this.tbVerticleName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // tbSolutionName
            // 
            this.tbSolutionName.Location = new System.Drawing.Point(91, 57);
            this.tbSolutionName.Name = "tbSolutionName";
            this.tbSolutionName.Size = new System.Drawing.Size(487, 20);
            this.tbSolutionName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path:";
            // 
            // tbSolutionPath
            // 
            this.tbSolutionPath.Location = new System.Drawing.Point(91, 23);
            this.tbSolutionPath.Name = "tbSolutionPath";
            this.tbSolutionPath.Size = new System.Drawing.Size(516, 20);
            this.tbSolutionPath.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(477, 654);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(558, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(621, 26);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contracts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contracts:";
            // 
            // tbDomainContracts
            // 
            this.tbDomainContracts.Location = new System.Drawing.Point(380, 24);
            this.tbDomainContracts.Name = "tbDomainContracts";
            this.tbDomainContracts.Size = new System.Drawing.Size(227, 20);
            this.tbDomainContracts.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Models:";
            // 
            // cbDataContracts
            // 
            this.cbDataContracts.DisplayMember = "Name";
            this.cbDataContracts.FormattingEnabled = true;
            this.cbDataContracts.Location = new System.Drawing.Point(70, 24);
            this.cbDataContracts.Name = "cbDataContracts";
            this.cbDataContracts.Size = new System.Drawing.Size(301, 21);
            this.cbDataContracts.TabIndex = 14;
            this.cbDataContracts.ValueMember = "Name";
            // 
            // tbDataContracts
            // 
            this.tbDataContracts.Location = new System.Drawing.Point(380, 24);
            this.tbDataContracts.Name = "tbDataContracts";
            this.tbDataContracts.Size = new System.Drawing.Size(227, 20);
            this.tbDataContracts.TabIndex = 15;
            // 
            // cbDomainContracts
            // 
            this.cbDomainContracts.DisplayMember = "Name";
            this.cbDomainContracts.FormattingEnabled = true;
            this.cbDomainContracts.Location = new System.Drawing.Point(70, 24);
            this.cbDomainContracts.Name = "cbDomainContracts";
            this.cbDomainContracts.Size = new System.Drawing.Size(301, 21);
            this.cbDomainContracts.TabIndex = 16;
            this.cbDomainContracts.ValueMember = "Name";
            // 
            // cbViewModels
            // 
            this.cbViewModels.DisplayMember = "Name";
            this.cbViewModels.FormattingEnabled = true;
            this.cbViewModels.Location = new System.Drawing.Point(70, 25);
            this.cbViewModels.Name = "cbViewModels";
            this.cbViewModels.Size = new System.Drawing.Size(301, 21);
            this.cbViewModels.TabIndex = 17;
            this.cbViewModels.ValueMember = "Name";
            // 
            // tbViewModels
            // 
            this.tbViewModels.Location = new System.Drawing.Point(380, 25);
            this.tbViewModels.Name = "tbViewModels";
            this.tbViewModels.Size = new System.Drawing.Size(227, 20);
            this.tbViewModels.TabIndex = 18;
            this.tbViewModels.Text = "Models";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Models:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Models:";
            // 
            // cbDataModels
            // 
            this.cbDataModels.DisplayMember = "Name";
            this.cbDataModels.FormattingEnabled = true;
            this.cbDataModels.Location = new System.Drawing.Point(70, 60);
            this.cbDataModels.Name = "cbDataModels";
            this.cbDataModels.Size = new System.Drawing.Size(301, 21);
            this.cbDataModels.TabIndex = 21;
            this.cbDataModels.ValueMember = "Name";
            // 
            // cbDomainModels
            // 
            this.cbDomainModels.DisplayMember = "Name";
            this.cbDomainModels.FormattingEnabled = true;
            this.cbDomainModels.Location = new System.Drawing.Point(70, 61);
            this.cbDomainModels.Name = "cbDomainModels";
            this.cbDomainModels.Size = new System.Drawing.Size(301, 21);
            this.cbDomainModels.TabIndex = 22;
            this.cbDomainModels.ValueMember = "Name";
            // 
            // tbDataModels
            // 
            this.tbDataModels.Location = new System.Drawing.Point(380, 60);
            this.tbDataModels.Name = "tbDataModels";
            this.tbDataModels.Size = new System.Drawing.Size(227, 20);
            this.tbDataModels.TabIndex = 23;
            // 
            // tbDomainModels
            // 
            this.tbDomainModels.Location = new System.Drawing.Point(380, 61);
            this.tbDomainModels.Name = "tbDomainModels";
            this.tbDomainModels.Size = new System.Drawing.Size(227, 20);
            this.tbDomainModels.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Controllers:";
            // 
            // cbControllers
            // 
            this.cbControllers.DisplayMember = "Name";
            this.cbControllers.FormattingEnabled = true;
            this.cbControllers.Location = new System.Drawing.Point(70, 118);
            this.cbControllers.Name = "cbControllers";
            this.cbControllers.Size = new System.Drawing.Size(301, 21);
            this.cbControllers.TabIndex = 26;
            this.cbControllers.ValueMember = "Name";
            // 
            // tbControllers
            // 
            this.tbControllers.Location = new System.Drawing.Point(380, 118);
            this.tbControllers.Name = "tbControllers";
            this.tbControllers.Size = new System.Drawing.Size(227, 20);
            this.tbControllers.TabIndex = 27;
            this.tbControllers.Text = "Controllers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Scripts:";
            // 
            // cbScriptModules
            // 
            this.cbScriptModules.DisplayMember = "Name";
            this.cbScriptModules.FormattingEnabled = true;
            this.cbScriptModules.Location = new System.Drawing.Point(70, 155);
            this.cbScriptModules.Name = "cbScriptModules";
            this.cbScriptModules.Size = new System.Drawing.Size(301, 21);
            this.cbScriptModules.TabIndex = 29;
            this.cbScriptModules.ValueMember = "Name";
            // 
            // tbScriptModules
            // 
            this.tbScriptModules.Location = new System.Drawing.Point(380, 155);
            this.tbScriptModules.Name = "tbScriptModules";
            this.tbScriptModules.Size = new System.Drawing.Size(227, 20);
            this.tbScriptModules.TabIndex = 30;
            this.tbScriptModules.Text = "Scripts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Views:";
            // 
            // cbViews
            // 
            this.cbViews.DisplayMember = "Name";
            this.cbViews.FormattingEnabled = true;
            this.cbViews.Location = new System.Drawing.Point(70, 62);
            this.cbViews.Name = "cbViews";
            this.cbViews.Size = new System.Drawing.Size(301, 21);
            this.cbViews.TabIndex = 32;
            this.cbViews.ValueMember = "Name";
            // 
            // tbViews
            // 
            this.tbViews.Location = new System.Drawing.Point(380, 62);
            this.tbViews.Name = "tbViews";
            this.tbViews.Size = new System.Drawing.Size(227, 20);
            this.tbViews.TabIndex = 33;
            this.tbViews.Text = "Views";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(565, 117);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(42, 23);
            this.btnParse.TabIndex = 34;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDataContracts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDataContracts);
            this.groupBox1.Controls.Add(this.cbDataModels);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbDataModels);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 100);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDomainContracts);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDomainContracts);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbDomainModels);
            this.groupBox2.Controls.Add(this.tbDomainModels);
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 100);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkCreate);
            this.groupBox3.Controls.Add(this.chkDetails);
            this.groupBox3.Controls.Add(this.chkEdit);
            this.groupBox3.Controls.Add(this.chkList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbViewModels);
            this.groupBox3.Controls.Add(this.tbViewModels);
            this.groupBox3.Controls.Add(this.cbViews);
            this.groupBox3.Controls.Add(this.tbScriptModules);
            this.groupBox3.Controls.Add(this.tbViews);
            this.groupBox3.Controls.Add(this.cbScriptModules);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbControllers);
            this.groupBox3.Controls.Add(this.cbControllers);
            this.groupBox3.Location = new System.Drawing.Point(12, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 196);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MVC";
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Location = new System.Drawing.Point(380, 88);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(42, 17);
            this.chkList.TabIndex = 34;
            this.chkList.Text = "List";
            this.chkList.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbSolutionPath);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnParse);
            this.groupBox4.Controls.Add(this.tbSolutionName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbVerticleName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 153);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solution";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = ".sln";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(491, 88);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(44, 17);
            this.chkEdit.TabIndex = 35;
            this.chkEdit.Text = "Edit";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Location = new System.Drawing.Point(541, 88);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(58, 17);
            this.chkDetails.TabIndex = 36;
            this.chkDetails.Text = "Details";
            this.chkDetails.UseVisualStyleBackColor = true;
            // 
            // chkCreate
            // 
            this.chkCreate.AutoSize = true;
            this.chkCreate.Location = new System.Drawing.Point(428, 88);
            this.chkCreate.Name = "chkCreate";
            this.chkCreate.Size = new System.Drawing.Size(57, 17);
            this.chkCreate.TabIndex = 37;
            this.chkCreate.Text = "Create";
            this.chkCreate.UseVisualStyleBackColor = true;
            // 
            // CodeGenerator
            // 
            this.ClientSize = new System.Drawing.Size(644, 688);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CodeGenerator";
            this.Text = "Code Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVerticleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSolutionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSolutionPath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDomainContracts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDataContracts;
        private System.Windows.Forms.TextBox tbDataContracts;
        private System.Windows.Forms.ComboBox cbDomainContracts;
        private System.Windows.Forms.ComboBox cbViewModels;
        private System.Windows.Forms.TextBox tbViewModels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDataModels;
        private System.Windows.Forms.ComboBox cbDomainModels;
        private System.Windows.Forms.TextBox tbDataModels;
        private System.Windows.Forms.TextBox tbDomainModels;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbControllers;
        private System.Windows.Forms.TextBox tbControllers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbScriptModules;
        private System.Windows.Forms.TextBox tbScriptModules;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbViews;
        private System.Windows.Forms.TextBox tbViews;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkCreate;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.CheckBox chkEdit;
    }
}

