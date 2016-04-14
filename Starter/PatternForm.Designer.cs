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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternForm));
            this.tabControlPattern = new System.Windows.Forms.TabControl();
            this.tabPageUI = new System.Windows.Forms.TabPage();
            this.tabPageSourceCode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.cmbFileName = new System.Windows.Forms.ComboBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabControlPattern.SuspendLayout();
            this.tabPageSourceCode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPattern
            // 
            this.tabControlPattern.Controls.Add(this.tabPageUI);
            this.tabControlPattern.Controls.Add(this.tabPageSourceCode);
            this.tabControlPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPattern.Location = new System.Drawing.Point(0, 0);
            this.tabControlPattern.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlPattern.Name = "tabControlPattern";
            this.tabControlPattern.Padding = new System.Drawing.Point(0, 0);
            this.tabControlPattern.SelectedIndex = 0;
            this.tabControlPattern.Size = new System.Drawing.Size(684, 466);
            this.tabControlPattern.TabIndex = 2;
            // 
            // tabPageUI
            // 
            this.tabPageUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageUI.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageUI.Name = "tabPageUI";
            this.tabPageUI.Size = new System.Drawing.Size(676, 440);
            this.tabPageUI.TabIndex = 0;
            this.tabPageUI.Text = "UI";
            this.tabPageUI.UseVisualStyleBackColor = true;
            // 
            // tabPageSourceCode
            // 
            this.tabPageSourceCode.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSourceCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSourceCode.Name = "tabPageSourceCode";
            this.tabPageSourceCode.Size = new System.Drawing.Size(676, 436);
            this.tabPageSourceCode.TabIndex = 1;
            this.tabPageSourceCode.Text = "SourceCode";
            this.tabPageSourceCode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmbLanguage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 436);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(203, 3);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(170, 21);
            this.cmbLanguage.TabIndex = 3;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // cmbFileName
            // 
            this.cmbFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileName.FormattingEnabled = true;
            this.cmbFileName.Location = new System.Drawing.Point(3, 3);
            this.cmbFileName.Name = "cmbFileName";
            this.cmbFileName.Size = new System.Drawing.Size(194, 21);
            this.cmbFileName.TabIndex = 2;
            this.cmbFileName.SelectedIndexChanged += new System.EventHandler(this.cmbFileName_SelectedIndexChanged);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.tableLayoutPanel1.SetColumnSpan(this.fastColoredTextBox1, 3);
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 33);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(670, 400);
            this.fastColoredTextBox1.TabIndex = 4;
            this.fastColoredTextBox1.Text = "fastColoredTextBox1";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 466);
            this.Controls.Add(this.tabControlPattern);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "PatternForm";
            this.ShowIcon = false;
            this.Text = "PatternForm";
            this.Load += new System.EventHandler(this.PatternForm_Load);
            this.tabControlPattern.ResumeLayout(false);
            this.tabPageSourceCode.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPattern;
        protected System.Windows.Forms.TabPage tabPageUI;
        protected System.Windows.Forms.TabPage tabPageSourceCode;
        private System.Windows.Forms.ComboBox cmbFileName;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}