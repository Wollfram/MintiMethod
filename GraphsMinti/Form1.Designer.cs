namespace GraphsMinti
{
    partial class MainForm
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
            this.buttonCreateNewGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVertex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateNewGraph
            // 
            this.buttonCreateNewGraph.Location = new System.Drawing.Point(232, 17);
            this.buttonCreateNewGraph.Name = "buttonCreateNewGraph";
            this.buttonCreateNewGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNewGraph.TabIndex = 0;
            this.buttonCreateNewGraph.Text = "Create";
            this.buttonCreateNewGraph.UseVisualStyleBackColor = true;
            this.buttonCreateNewGraph.Click += new System.EventHandler(this.buttonCreateNewGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of vertices";
            // 
            // textBoxVertex
            // 
            this.textBoxVertex.Location = new System.Drawing.Point(114, 19);
            this.textBoxVertex.Name = "textBoxVertex";
            this.textBoxVertex.Size = new System.Drawing.Size(100, 20);
            this.textBoxVertex.TabIndex = 2;
            this.textBoxVertex.Text = "4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 66);
            this.Controls.Add(this.textBoxVertex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateNewGraph);
            this.Name = "MainForm";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVertex;
    }
}

