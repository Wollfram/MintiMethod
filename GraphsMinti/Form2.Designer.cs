namespace GraphsMinti
{
    partial class GraphForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.dataGridViewPaths = new System.Windows.Forms.DataGridView();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDest = new System.Windows.Forms.ComboBox();
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxShowSingles = new System.Windows.Forms.CheckBox();
            this.checkBoxShowAllMinPaths = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaths)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPaths
            // 
            this.dataGridViewPaths.AllowUserToAddRows = false;
            this.dataGridViewPaths.AllowUserToDeleteRows = false;
            this.dataGridViewPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaths.Location = new System.Drawing.Point(10, 27);
            this.dataGridViewPaths.Name = "dataGridViewPaths";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaths.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPaths.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPaths.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPaths.Size = new System.Drawing.Size(694, 297);
            this.dataGridViewPaths.TabIndex = 0;
            this.dataGridViewPaths.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaths_CellValueChanged);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(75, 332);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(97, 21);
            this.comboBoxSource.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Джерело";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.Location = new System.Drawing.Point(384, 330);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(322, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Відшукати найкоротший шлях (алгоритм Мінті)";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Стік";
            // 
            // comboBoxDest
            // 
            this.comboBoxDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDest.FormattingEnabled = true;
            this.comboBoxDest.Location = new System.Drawing.Point(75, 362);
            this.comboBoxDest.Name = "comboBoxDest";
            this.comboBoxDest.Size = new System.Drawing.Size(97, 21);
            this.comboBoxDest.TabIndex = 4;
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowMap.Location = new System.Drawing.Point(384, 362);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(322, 23);
            this.buttonShowMap.TabIndex = 5;
            this.buttonShowMap.Text = "Перебудувати мережу (без перерахування)";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.fileToolStripMenuItem.Text = "Зберегти мережу в файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.saveGraphToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Довідка";
            // 
            // checkBoxShowSingles
            // 
            this.checkBoxShowSingles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowSingles.AutoSize = true;
            this.checkBoxShowSingles.Checked = true;
            this.checkBoxShowSingles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSingles.Location = new System.Drawing.Point(193, 334);
            this.checkBoxShowSingles.Name = "checkBoxShowSingles";
            this.checkBoxShowSingles.Size = new System.Drawing.Size(177, 17);
            this.checkBoxShowSingles.TabIndex = 7;
            this.checkBoxShowSingles.Text = "Показати ізольовані вершини";
            this.checkBoxShowSingles.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowAllMinPaths
            // 
            this.checkBoxShowAllMinPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowAllMinPaths.AutoSize = true;
            this.checkBoxShowAllMinPaths.Checked = true;
            this.checkBoxShowAllMinPaths.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowAllMinPaths.Location = new System.Drawing.Point(193, 366);
            this.checkBoxShowAllMinPaths.Name = "checkBoxShowAllMinPaths";
            this.checkBoxShowAllMinPaths.Size = new System.Drawing.Size(185, 17);
            this.checkBoxShowAllMinPaths.TabIndex = 7;
            this.checkBoxShowAllMinPaths.Text = "Показати усі найкоротші шляхи";
            this.checkBoxShowAllMinPaths.UseVisualStyleBackColor = true;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 394);
            this.Controls.Add(this.checkBoxShowAllMinPaths);
            this.Controls.Add(this.checkBoxShowSingles);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.comboBoxDest);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPaths);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(436, 292);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaths)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaths;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDest;
        private System.Windows.Forms.Button buttonShowMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxShowSingles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxShowAllMinPaths;
    }
}