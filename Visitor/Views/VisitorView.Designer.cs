namespace DP.Visitor.Views
{
    partial class VisitorView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbElements = new System.Windows.Forms.GroupBox();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbOperations);
            this.splitContainer1.Panel1.Controls.Add(this.btnDraw);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.gbElements);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxElements);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(720, 435);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbOperations
            // 
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOperations.Location = new System.Drawing.Point(0, 319);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(169, 81);
            this.gbOperations.TabIndex = 3;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDraw.Location = new System.Drawing.Point(84, 409);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(3, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Element";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbElements
            // 
            this.gbElements.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbElements.Location = new System.Drawing.Point(0, 238);
            this.gbElements.Name = "gbElements";
            this.gbElements.Size = new System.Drawing.Size(169, 81);
            this.gbElements.TabIndex = 2;
            this.gbElements.TabStop = false;
            this.gbElements.Text = "Elements";
            // 
            // listBoxElements
            // 
            this.listBoxElements.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.Location = new System.Drawing.Point(0, 0);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(169, 238);
            this.listBoxElements.TabIndex = 0;
            // 
            // VisitorView
            // 
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(720, 435);
            this.Name = "VisitorView";
            this.Size = new System.Drawing.Size(720, 435);
            this.Load += new System.EventHandler(this.VisitorView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbElements;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.GroupBox gbOperations;
    }
}
