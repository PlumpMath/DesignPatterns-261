namespace Starter
{
    partial class Wizard97Pattern
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
            this.topDivider = new System.Windows.Forms.Label();
            this.bottomDivider = new System.Windows.Forms.Label();
            this.wizardPageContainer1 = new AeroWizard.WizardPageContainer();
            this.wizardPage2 = new AeroWizard.WizardPage();
            this.tabControlPattern = new System.Windows.Forms.TabControl();
            this.tabPageSourceCode = new System.Windows.Forms.TabPage();
            this.tabPageUI = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.wizardPage1 = new AeroWizard.WizardPage();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPageContainer1)).BeginInit();
            this.wizardPageContainer1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            this.tabControlPattern.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topDivider
            // 
            this.topDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDivider.Location = new System.Drawing.Point(0, 0);
            this.topDivider.Name = "topDivider";
            this.topDivider.Size = new System.Drawing.Size(480, 2);
            this.topDivider.TabIndex = 3;
            // 
            // bottomDivider
            // 
            this.bottomDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDivider.Enabled = false;
            this.bottomDivider.Location = new System.Drawing.Point(0, 353);
            this.bottomDivider.Name = "bottomDivider";
            this.bottomDivider.Size = new System.Drawing.Size(480, 2);
            this.bottomDivider.TabIndex = 4;
            // 
            // wizardPageContainer1
            // 
            this.wizardPageContainer1.BackButton = null;
            this.wizardPageContainer1.BackButtonText = "";
            this.wizardPageContainer1.CancelButton = null;
            this.wizardPageContainer1.CancelButtonText = "";
            this.wizardPageContainer1.Controls.Add(this.wizardPage2);
            this.wizardPageContainer1.Controls.Add(this.wizardPage1);
            this.wizardPageContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPageContainer1.Location = new System.Drawing.Point(0, 2);
            this.wizardPageContainer1.Name = "wizardPageContainer1";
            this.wizardPageContainer1.NextButton = null;
            this.wizardPageContainer1.Pages.Add(this.wizardPage1);
            this.wizardPageContainer1.Pages.Add(this.wizardPage2);
            this.wizardPageContainer1.Size = new System.Drawing.Size(480, 351);
            this.wizardPageContainer1.TabIndex = 0;
            this.wizardPageContainer1.Finished += new System.EventHandler(this.wizardPageContainer1_Finished);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.tabControlPattern);
            this.wizardPage2.Controls.Add(this.flowLayoutPanel1);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(480, 351);
            this.wizardPage2.TabIndex = 1;
            this.wizardPage2.Tag = "";
            this.wizardPage2.Text = "Page 2 - Middle|This is the middle page";
            this.wizardPage2.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wizardPage2_Initialize);
            // 
            // tabControlPattern
            // 
            this.tabControlPattern.Controls.Add(this.tabPageUI);
            this.tabControlPattern.Controls.Add(this.tabPageSourceCode);
            this.tabControlPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPattern.Location = new System.Drawing.Point(0, 34);
            this.tabControlPattern.Name = "tabControlPattern";
            this.tabControlPattern.SelectedIndex = 0;
            this.tabControlPattern.Size = new System.Drawing.Size(480, 317);
            this.tabControlPattern.TabIndex = 1;
            this.tabControlPattern.SelectedIndexChanged += new System.EventHandler(this.tabControlPattern_SelectedIndexChanged);
            // 
            // tabPageSourceCode
            // 
            this.tabPageSourceCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceCode.Name = "tabPageSourceCode";
            this.tabPageSourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSourceCode.Size = new System.Drawing.Size(472, 295);
            this.tabPageSourceCode.TabIndex = 1;
            this.tabPageSourceCode.Text = "SourceCode";
            this.tabPageSourceCode.UseVisualStyleBackColor = true;
            // 
            // tabPageUI
            // 
            this.tabPageUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageUI.Name = "tabPageUI";
            this.tabPageUI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUI.Size = new System.Drawing.Size(472, 291);
            this.tabPageUI.TabIndex = 0;
            this.tabPageUI.Text = "UI";
            this.tabPageUI.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPrev);
            this.flowLayoutPanel1.Controls.Add(this.cmbCode);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cmbCode
            // 
            this.cmbCode.Enabled = false;
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(84, 3);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(121, 21);
            this.cmbCode.TabIndex = 1;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(480, 351);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Text = "Welcom";
            this.wizardPage1.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wizardPage1_Initialize);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::Starter.Properties.Resources.Back1;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 25);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Back";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Wizard97Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 355);
            this.Controls.Add(this.wizardPageContainer1);
            this.Controls.Add(this.bottomDivider);
            this.Controls.Add(this.topDivider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Wizard97Pattern";
            this.Text = "Design patterns";
            ((System.ComponentModel.ISupportInitialize)(this.wizardPageContainer1)).EndInit();
            this.wizardPageContainer1.ResumeLayout(false);
            this.wizardPage2.ResumeLayout(false);
            this.tabControlPattern.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardPageContainer wizardPageContainer1;
        private System.Windows.Forms.Label topDivider;
        private System.Windows.Forms.Label bottomDivider;
        private AeroWizard.WizardPage wizardPage2;
        private AeroWizard.WizardPage wizardPage1;
        private System.Windows.Forms.TabControl tabControlPattern;
        protected System.Windows.Forms.TabPage tabPageUI;
        protected System.Windows.Forms.TabPage tabPageSourceCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cmbCode;
    }
}