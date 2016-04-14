namespace DP.Adapter
{
    partial class AdapterForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSaveExt = new System.Windows.Forms.Button();
            this.btnLoadExt = new System.Windows.Forms.Button();
            this.tabControlAdapter = new System.Windows.Forms.TabControl();
            this.tabPageCommon = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageExt = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlAdapter.SuspendLayout();
            this.tabPageCommon.SuspendLayout();
            this.tabPageExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(664, 383);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReverse.Enabled = false;
            this.btnReverse.Location = new System.Drawing.Point(664, 383);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSaveExt
            // 
            this.btnSaveExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExt.Enabled = false;
            this.btnSaveExt.Location = new System.Drawing.Point(571, 383);
            this.btnSaveExt.Name = "btnSaveExt";
            this.btnSaveExt.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExt.TabIndex = 2;
            this.btnSaveExt.Text = "Save";
            this.btnSaveExt.UseVisualStyleBackColor = true;
            this.btnSaveExt.Click += new System.EventHandler(this.btnSaveExt_Click);
            // 
            // btnLoadExt
            // 
            this.btnLoadExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadExt.Location = new System.Drawing.Point(480, 383);
            this.btnLoadExt.Name = "btnLoadExt";
            this.btnLoadExt.Size = new System.Drawing.Size(75, 23);
            this.btnLoadExt.TabIndex = 1;
            this.btnLoadExt.Text = "Load";
            this.btnLoadExt.UseVisualStyleBackColor = true;
            this.btnLoadExt.Click += new System.EventHandler(this.btnLoadExt_Click);
            // 
            // tabControlAdapter
            // 
            this.tabControlAdapter.Controls.Add(this.tabPageCommon);
            this.tabControlAdapter.Controls.Add(this.tabPageExt);
            this.tabControlAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdapter.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdapter.Name = "tabControlAdapter";
            this.tabControlAdapter.SelectedIndex = 0;
            this.tabControlAdapter.Size = new System.Drawing.Size(753, 438);
            this.tabControlAdapter.TabIndex = 1;
            // 
            // tabPageCommon
            // 
            this.tabPageCommon.Controls.Add(this.panel1);
            this.tabPageCommon.Controls.Add(this.btnLoad);
            this.tabPageCommon.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommon.Name = "tabPageCommon";
            this.tabPageCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommon.Size = new System.Drawing.Size(745, 412);
            this.tabPageCommon.TabIndex = 0;
            this.tabPageCommon.Text = "IPictureControl";
            this.tabPageCommon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 362);
            this.panel1.TabIndex = 1;
            // 
            // tabPageExt
            // 
            this.tabPageExt.Controls.Add(this.panel2);
            this.tabPageExt.Controls.Add(this.btnReverse);
            this.tabPageExt.Controls.Add(this.btnSaveExt);
            this.tabPageExt.Controls.Add(this.btnLoadExt);
            this.tabPageExt.Location = new System.Drawing.Point(4, 22);
            this.tabPageExt.Name = "tabPageExt";
            this.tabPageExt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExt.Size = new System.Drawing.Size(745, 412);
            this.tabPageExt.TabIndex = 1;
            this.tabPageExt.Text = "IPictureControlExt";
            this.tabPageExt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 362);
            this.panel2.TabIndex = 4;
            // 
            // AdapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tabControlAdapter);
            this.Name = "AdapterForm";
            this.Size = new System.Drawing.Size(753, 438);
            this.Load += new System.EventHandler(this.AdapterForm_Load);
            this.tabControlAdapter.ResumeLayout(false);
            this.tabPageCommon.ResumeLayout(false);
            this.tabPageExt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveExt;
        private System.Windows.Forms.Button btnLoadExt;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TabControl tabControlAdapter;
        private System.Windows.Forms.TabPage tabPageCommon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageExt;
        private System.Windows.Forms.Panel panel2;
    }
}

