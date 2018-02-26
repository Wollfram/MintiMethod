using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsMinti
{
    public partial class GraphForm : Form
    {        //for double comparsion
        private static double TOLERANCE = 0.00001;
        private Graph graph;
        private int verticesCount;
        private Graph.MintiNode[] mintiRez;
        private int mintiRezStartIdx;
        public GraphForm(int vertices)
        {
            InitializeComponent();
            verticesCount = vertices;
            for (int i = 0; i < vertices; i++) {
                comboBoxSource.Items.Add(i+1);
                comboBoxDest.Items.Add(i+1);
                dataGridViewPaths.Columns.Add(i.ToString(), (i+1).ToString());
                dataGridViewPaths.Columns[i].Width = 30;
                dataGridViewPaths.Rows.Add();
                dataGridViewPaths.Rows[i].HeaderCell.Value = (i+1).ToString();
                dataGridViewPaths.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            comboBoxDest.Items.Add("Будь який");
            comboBoxSource.SelectedIndex = 0;
            comboBoxDest.SelectedIndex = comboBoxDest.Items.Count-1;
            
        }

        public GraphForm(Graph graph) {
            InitializeComponent();
            verticesCount = graph.VertexCount;
            this.graph = graph;
            for (int i = 0; i < verticesCount; i++) {
                comboBoxSource.Items.Add(i + 1);
                comboBoxDest.Items.Add(i + 1);
                dataGridViewPaths.Columns.Add(i.ToString(), (i + 1).ToString());
                dataGridViewPaths.Columns[i].Width = 30;
                dataGridViewPaths.Rows.Add();
                dataGridViewPaths.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridViewPaths.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            comboBoxDest.Items.Add("Будь який");
            comboBoxSource.SelectedIndex = 0;
            comboBoxDest.SelectedIndex = comboBoxDest.Items.Count - 1;

            for (int i = 0; i < dataGridViewPaths.RowCount; i++) {
                for (int j = 0; j < dataGridViewPaths.ColumnCount; j++) {
                    if (Math.Abs(this.graph[i, j] - (-1)) > TOLERANCE)
                        dataGridViewPaths[j, i].Value = this.graph[i, j];
                }
            }
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                ReadGraphFromDataGrid();
                int startIdx = comboBoxSource.SelectedIndex;
                int endIdx = (comboBoxDest.SelectedIndex < comboBoxDest.Items.Count-1) ? comboBoxDest.SelectedIndex : -1;
                mintiRez = graph.DoMinti(startIdx);
                mintiRezStartIdx = startIdx;
                string filename = "graph.gr";
                string filepath = Directory.GetCurrentDirectory();

                //generate graph script
                System.IO.File.WriteAllText(Path.Combine(filepath, filename), graph.ToMintyDotGraph(startIdx, endIdx, mintiRez, checkBoxShowSingles.Checked,checkBoxShowAllMinPaths.Checked));
                //create graph file
                GenerateGraph(filename, filepath);
                //show image
                System.Diagnostics.Process.Start(Path.Combine(filepath, filename.Replace(".gr", ".jpeg")));

            }
            catch (Exception exception) {
                MessageBox.Show("Неможливо порахувати");
#if DEBUG
                throw;
#endif
            }
        }

        private void ReadGraphFromDataGrid() {
            graph = new Graph(verticesCount);
            for (int i = 0; i < dataGridViewPaths.RowCount; i++) {
                for (int j = 0; j < dataGridViewPaths.ColumnCount; j++) {
                    try {
                        if (dataGridViewPaths[j, i].Value != null)
                            graph[i, j] =
                                Double.Parse(dataGridViewPaths[j, i].Value.ToString());
                    }
                    catch (Exception e) {
                        MessageBox.Show("Неможливо зчитати");
                        throw;
                    }
                }
            }
        }

        private static void GenerateGraph(string fileName, string path)
        {
            try {
                var command = string.Format("\"\"" + Path.Combine(path, "gviz\\bin\\dot") + "\" -Tjpeg \"{0}\" -o \"{1}\"\"", Path.Combine(path, fileName), Path.Combine(path, fileName.Replace(".gr", ".jpeg")));
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();

            }
            catch (Exception e) {
                MessageBox.Show("Неможливо згенерувати мережу");
#if DEBUG
                throw;
#endif
            }
        }

        private void buttonShowMap_Click(object sender, EventArgs e) {
            if (mintiRez == null) {
                MessageBox.Show("Обчислення не проведені");
                return;
            }
            try
            {
                int startIdx = mintiRezStartIdx;
                int endIdx = (comboBoxDest.SelectedIndex < comboBoxDest.Items.Count - 1) ? comboBoxDest.SelectedIndex : -1;
                string filename = "graph.gr";
                string filepath = Directory.GetCurrentDirectory();
                
                //generate graph script
                System.IO.File.WriteAllText(Path.Combine(filepath, filename), graph.ToMintyDotGraph(startIdx, endIdx, mintiRez, checkBoxShowSingles.Checked, checkBoxShowAllMinPaths.Checked));
                //create graph file
                GenerateGraph(filename, filepath);
                //show image
                System.Diagnostics.Process.Start(Path.Combine(filepath, filename.Replace(".gr", ".jpeg")));

            }
            catch (Exception exception)
            {
                MessageBox.Show("Неможливо відобразити");
#if DEBUG
                throw;
#endif
            }
        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e) {
            try
            {
                if (graph == null) { ReadGraphFromDataGrid(); }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    graph.Save(saveFileDialog1.FileName);
                }
            }
            catch (Exception exception) {
                MessageBox.Show("Неможливо зберегти");
#if DEBUG
                throw;
#endif
            }

        }

        private void dataGridViewPaths_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                    dataGridViewPaths[e.ColumnIndex, e.RowIndex].Value != null) {
                    double a = double.Parse(dataGridViewPaths[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (a < 0) throw new Exception();
                }
            }
            catch (Exception exception) {
                dataGridViewPaths[e.ColumnIndex, e.RowIndex].Value = null;
                MessageBox.Show("Введіть дійсне додатнє число через \',\'");
            }
        }
    }
}
