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
            this.wizardPage1 = new AeroWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPageContainer1)).BeginInit();
            this.wizardPageContainer1.SuspendLayout();
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
            this.wizardPageContainer1.Controls.Add(this.wizardPage1);
            this.wizardPageContainer1.Controls.Add(this.wizardPage2);
            this.wizardPageContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPageContainer1.Location = new System.Drawing.Point(0, 2);
            this.wizardPageContainer1.Name = "wizardPageContainer1";
            this.wizardPageContainer1.NextButton = null;
            this.wizardPageContainer1.Pages.Add(this.wizardPage1);
            this.wizardPageContainer1.Pages.Add(this.wizardPage2);
            this.wizardPageContainer1.Size = new System.Drawing.Size(480, 351);
            this.wizardPageContainer1.TabIndex = 0;
            this.wizardPageContainer1.Finished += new System.EventHandler(this.wizardPageContainer1_Finished);
            this.wizardPageContainer1.SelectedPageChanged += new System.EventHandler(this.wizardPageContainer1_SelectedPageChanged);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(480, 351);
            this.wizardPage2.TabIndex = 1;
            this.wizardPage2.Tag = "";
            this.wizardPage2.Text = "Page 2 - Middle|This is the middle page";
            this.wizardPage2.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wizardPage2_Initialize);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(480, 351);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Text = "Welcom";
            this.wizardPage1.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wizardPage1_Initialize);
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
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardPageContainer wizardPageContainer1;
        private System.Windows.Forms.Label topDivider;
        private System.Windows.Forms.Label bottomDivider;
        private AeroWizard.WizardPage wizardPage2;
        private AeroWizard.WizardPage wizardPage1;
    }
}