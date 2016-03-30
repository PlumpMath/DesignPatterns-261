namespace Starter
{
    partial class PatternForm
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
            this.tabControlPattern = new System.Windows.Forms.TabControl();
            this.tabPageUI = new System.Windows.Forms.TabPage();
            this.tabPageSourceCode = new System.Windows.Forms.TabPage();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.tabControlPattern.SuspendLayout();
            this.tabPageSourceCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPattern
            // 
            this.tabControlPattern.Controls.Add(this.tabPageUI);
            this.tabControlPattern.Controls.Add(this.tabPageSourceCode);
            this.tabControlPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPattern.Location = new System.Drawing.Point(0, 0);
            this.tabControlPattern.Name = "tabControlPattern";
            this.tabControlPattern.SelectedIndex = 0;
            this.tabControlPattern.Size = new System.Drawing.Size(612, 339);
            this.tabControlPattern.TabIndex = 2;
            // 
            // tabPageUI
            // 
            this.tabPageUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageUI.Name = "tabPageUI";
            this.tabPageUI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUI.Size = new System.Drawing.Size(604, 313);
            this.tabPageUI.TabIndex = 0;
            this.tabPageUI.Text = "UI";
            this.tabPageUI.UseVisualStyleBackColor = true;
            // 
            // tabPageSourceCode
            // 
            this.tabPageSourceCode.Controls.Add(this.cmbCode);
            this.tabPageSourceCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceCode.Name = "tabPageSourceCode";
            this.tabPageSourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSourceCode.Size = new System.Drawing.Size(604, 313);
            this.tabPageSourceCode.TabIndex = 1;
            this.tabPageSourceCode.Text = "SourceCode";
            this.tabPageSourceCode.UseVisualStyleBackColor = true;
            // 
            // cmbCode
            // 
            this.cmbCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCode.Enabled = false;
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(3, 3);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(598, 21);
            this.cmbCode.TabIndex = 2;
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 339);
            this.Controls.Add(this.tabControlPattern);
            this.Name = "PatternForm";
            this.ShowIcon = false;
            this.Text = "PatternForm";
            this.tabControlPattern.ResumeLayout(false);
            this.tabPageSourceCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPattern;
        protected System.Windows.Forms.TabPage tabPageUI;
        protected System.Windows.Forms.TabPage tabPageSourceCode;
        private System.Windows.Forms.ComboBox cmbCode;
    }
}