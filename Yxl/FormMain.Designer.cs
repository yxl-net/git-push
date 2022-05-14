
namespace Yxl.GitPush
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.dgvRepo = new System.Windows.Forms.DataGridView();
            this.tsRepo = new System.Windows.Forms.ToolStrip();
            this.tslRepoTitle = new System.Windows.Forms.ToolStripLabel();
            this.dgvCommit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCommit = new System.Windows.Forms.ToolStrip();
            this.tslCommitTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstRepoFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tslRepoFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslCommitFilter = new System.Windows.Forms.ToolStripLabel();
            this.tstCommitFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb = new System.Windows.Forms.ToolStripButton();
            this.tsdRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiChangePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tslCommitCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tslRepoCount = new System.Windows.Forms.ToolStripLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepo)).BeginInit();
            this.tsRepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommit)).BeginInit();
            this.tsCommit.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.dgvRepo);
            this.sc.Panel1.Controls.Add(this.tsRepo);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.dgvCommit);
            this.sc.Panel2.Controls.Add(this.tsCommit);
            this.sc.Size = new System.Drawing.Size(946, 450);
            this.sc.SplitterDistance = 431;
            this.sc.TabIndex = 1;
            // 
            // dgvRepo
            // 
            this.dgvRepo.AllowUserToAddRows = false;
            this.dgvRepo.AllowUserToDeleteRows = false;
            this.dgvRepo.AllowUserToOrderColumns = true;
            this.dgvRepo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvRepo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cPath});
            this.dgvRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepo.Location = new System.Drawing.Point(0, 27);
            this.dgvRepo.Name = "dgvRepo";
            this.dgvRepo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRepo.RowHeadersVisible = false;
            this.dgvRepo.RowHeadersWidth = 51;
            this.dgvRepo.RowTemplate.Height = 27;
            this.dgvRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepo.Size = new System.Drawing.Size(431, 423);
            this.dgvRepo.TabIndex = 1;
            // 
            // tsRepo
            // 
            this.tsRepo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsRepo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRepoTitle,
            this.toolStripSeparator1,
            this.tslRepoFilter,
            this.tstRepoFilter,
            this.tsdRefresh,
            this.toolStripSeparator2,
            this.tsb,
            this.toolStripSeparator5,
            this.tslRepoCount});
            this.tsRepo.Location = new System.Drawing.Point(0, 0);
            this.tsRepo.Name = "tsRepo";
            this.tsRepo.Size = new System.Drawing.Size(431, 27);
            this.tsRepo.TabIndex = 0;
            this.tsRepo.Text = "toolStrip1";
            // 
            // tslRepoTitle
            // 
            this.tslRepoTitle.Name = "tslRepoTitle";
            this.tslRepoTitle.Size = new System.Drawing.Size(39, 24);
            this.tslRepoTitle.Text = "仓库";
            // 
            // dgvCommit
            // 
            this.dgvCommit.AllowUserToAddRows = false;
            this.dgvCommit.AllowUserToDeleteRows = false;
            this.dgvCommit.AllowUserToOrderColumns = true;
            this.dgvCommit.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.dgvCommit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCommit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCommit.ColumnHeadersHeight = 29;
            this.dgvCommit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCommit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCommit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCommit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommit.Location = new System.Drawing.Point(0, 27);
            this.dgvCommit.MultiSelect = false;
            this.dgvCommit.Name = "dgvCommit";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommit.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCommit.RowHeadersVisible = false;
            this.dgvCommit.RowHeadersWidth = 51;
            this.dgvCommit.RowTemplate.Height = 27;
            this.dgvCommit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCommit.Size = new System.Drawing.Size(511, 423);
            this.dgvCommit.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sProject";
            this.dataGridViewTextBoxColumn1.HeaderText = "项目";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sLabel";
            this.dataGridViewTextBoxColumn2.HeaderText = "标签";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sType";
            this.dataGridViewTextBoxColumn3.HeaderText = "类型";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 43;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "地址";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sAccount";
            this.dataGridViewTextBoxColumn5.HeaderText = "帐号";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 43;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sPassword";
            this.dataGridViewTextBoxColumn6.HeaderText = "密码";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 36;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 43;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "sRemark";
            this.Column7.HeaderText = "备注";
            this.Column7.MinimumWidth = 36;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tsCommit
            // 
            this.tsCommit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCommit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCommitTitle,
            this.toolStripSeparator3,
            this.tslCommitFilter,
            this.tstCommitFilter,
            this.toolStripSeparator4,
            this.tslCommitCount});
            this.tsCommit.Location = new System.Drawing.Point(0, 0);
            this.tsCommit.Name = "tsCommit";
            this.tsCommit.Size = new System.Drawing.Size(511, 27);
            this.tsCommit.TabIndex = 0;
            this.tsCommit.Text = "toolStrip2";
            // 
            // tslCommitTitle
            // 
            this.tslCommitTitle.Name = "tslCommitTitle";
            this.tslCommitTitle.Size = new System.Drawing.Size(39, 24);
            this.tslCommitTitle.Text = "容器";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tstRepoFilter
            // 
            this.tstRepoFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstRepoFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstRepoFilter.Name = "tstRepoFilter";
            this.tstRepoFilter.Size = new System.Drawing.Size(100, 27);
            // 
            // tslRepoFilter
            // 
            this.tslRepoFilter.Name = "tslRepoFilter";
            this.tslRepoFilter.Size = new System.Drawing.Size(43, 24);
            this.tslRepoFilter.Text = "搜索:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tslCommitFilter
            // 
            this.tslCommitFilter.Name = "tslCommitFilter";
            this.tslCommitFilter.Size = new System.Drawing.Size(43, 24);
            this.tslCommitFilter.Text = "搜索:";
            // 
            // tstCommitFilter
            // 
            this.tstCommitFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstCommitFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstCommitFilter.Name = "tstCommitFilter";
            this.tstCommitFilter.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb
            // 
            this.tsb.Image = ((System.Drawing.Image)(resources.GetObject("tsb.Image")));
            this.tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(63, 24);
            this.tsb.Text = "推送";
            // 
            // tsdRefresh
            // 
            this.tsdRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiChangePath});
            this.tsdRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsdRefresh.Image")));
            this.tsdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdRefresh.Name = "tsdRefresh";
            this.tsdRefresh.Size = new System.Drawing.Size(78, 24);
            this.tsdRefresh.Text = "刷新";
            // 
            // tsiChangePath
            // 
            this.tsiChangePath.Name = "tsiChangePath";
            this.tsiChangePath.Size = new System.Drawing.Size(224, 26);
            this.tsiChangePath.Text = "更改路径";
            // 
            // tslCommitCount
            // 
            this.tslCommitCount.Name = "tslCommitCount";
            this.tslCommitCount.Size = new System.Drawing.Size(18, 24);
            this.tslCommitCount.Text = "0";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tslRepoCount
            // 
            this.tslRepoCount.Name = "tslRepoCount";
            this.tslRepoCount.Size = new System.Drawing.Size(18, 24);
            this.tslRepoCount.Text = "0";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "sLocal";
            this.Column1.HeaderText = "本地目录";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sPush";
            this.Column2.HeaderText = "待推送";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // cPath
            // 
            this.cPath.DataPropertyName = "sPath";
            this.cPath.HeaderText = "路径";
            this.cPath.MinimumWidth = 6;
            this.cPath.Name = "cPath";
            this.cPath.ReadOnly = true;
            this.cPath.Visible = false;
            this.cPath.Width = 66;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.sc);
            this.Name = "FormMain";
            this.Text = "Git推送工具";
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            this.sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepo)).EndInit();
            this.tsRepo.ResumeLayout(false);
            this.tsRepo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommit)).EndInit();
            this.tsCommit.ResumeLayout(false);
            this.tsCommit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.DataGridView dgvRepo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPath;
        private System.Windows.Forms.ToolStrip tsRepo;
        private System.Windows.Forms.ToolStripLabel tslRepoTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslRepoFilter;
        private System.Windows.Forms.ToolStripTextBox tstRepoFilter;
        private System.Windows.Forms.ToolStripSplitButton tsdRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsiChangePath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel tslRepoCount;
        private System.Windows.Forms.DataGridView dgvCommit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStrip tsCommit;
        private System.Windows.Forms.ToolStripLabel tslCommitTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslCommitFilter;
        private System.Windows.Forms.ToolStripTextBox tstCommitFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tslCommitCount;
    }
}

