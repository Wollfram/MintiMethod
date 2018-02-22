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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaths.Location = new System.Drawing.Point(10, 27);
            this.dataGridViewPaths.Name = "dataGridViewPaths";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaths.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPaths.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPaths.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaths.Size = new System.Drawing.Size(694, 300);
            this.dataGridViewPaths.TabIndex = 0;
            this.dataGridViewPaths.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaths_CellValueChanged);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(75, 335);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(97, 21);
            this.comboBoxSource.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Джерело";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.Location = new System.Drawing.Point(193, 333);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(513, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Відшукати найкоротший шлях (алгоритм Мінті)";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Стік";
            // 
            // comboBoxDest
            // 
            this.comboBoxDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDest.FormattingEnabled = true;
            this.comboBoxDest.Location = new System.Drawing.Point(75, 365);
            this.comboBoxDest.Name = "comboBoxDest";
            this.comboBoxDest.Size = new System.Drawing.Size(97, 21);
            this.comboBoxDest.TabIndex = 4;
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowMap.Location = new System.Drawing.Point(376, 365);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(330, 23);
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
            this.checkBoxShowSingles.Location = new System.Drawing.Point(193, 369);
            this.checkBoxShowSingles.Name = "checkBoxShowSingles";
            this.checkBoxShowSingles.Size = new System.Drawing.Size(177, 17);
            this.checkBoxShowSingles.TabIndex = 7;
            this.checkBoxShowSingles.Text = "Показати ізольовані вершини";
            this.checkBoxShowSingles.UseVisualStyleBackColor = true;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 397);
            this.Controls.Add(this.checkBoxShowSingles);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.comboBoxDest);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPaths);
            this.Controls.Add(this.menuStrip1);
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
    }
}