namespace Common.Views
{
    partial class BaseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPattern = new System.Windows.Forms.TabControl();
            this.tabPageUI = new System.Windows.Forms.TabPage();
            this.tabPageSourceCode = new System.Windows.Forms.TabPage();
            this.tabControlPattern.SuspendLayout();
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
            this.tabControlPattern.Size = new System.Drawing.Size(565, 328);
            this.tabControlPattern.TabIndex = 0;
            // 
            // tabPageUI
            // 
            this.tabPageUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageUI.Name = "tabPageUI";
            this.tabPageUI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUI.Size = new System.Drawing.Size(557, 302);
            this.tabPageUI.TabIndex = 0;
            this.tabPageUI.Text = "UI";
            this.tabPageUI.UseVisualStyleBackColor = true;
            // 
            // tabPageSourceCode
            // 
            this.tabPageSourceCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceCode.Name = "tabPageSourceCode";
            this.tabPageSourceCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSourceCode.Size = new System.Drawing.Size(557, 302);
            this.tabPageSourceCode.TabIndex = 1;
            this.tabPageSourceCode.Text = "SourceCode";
            this.tabPageSourceCode.UseVisualStyleBackColor = true;
            // 
            // BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPattern);
            this.Name = "BaseView";
            this.Size = new System.Drawing.Size(565, 328);
            this.tabControlPattern.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPattern;
        private System.Windows.Forms.TabPage tabPageUI;
        private System.Windows.Forms.TabPage tabPageSourceCode;
    }
}
