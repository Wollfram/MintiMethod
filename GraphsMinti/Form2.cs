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
    public partial class GraphForm : Form {
        private Graph graph;
        private int verticesCount;
        private Graph.MintiNode[] mintiRez;
        public GraphForm(int vertices)
        {
            InitializeComponent();
            verticesCount = vertices;
            for (int i = 0; i < vertices; i++) {
                comboBoxSource.Items.Add(i);
                comboBoxDest.Items.Add(i);
                dataGridViewPaths.Columns.Add(i.ToString(), (i+1).ToString());
                dataGridViewPaths.Columns[i].Width = 30;
                dataGridViewPaths.Rows.Add();
                dataGridViewPaths.Rows[i].HeaderCell.Value = (i+1).ToString();
                dataGridViewPaths.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridViewPaths[i, i].ReadOnly = true;
                dataGridViewPaths[i, i].Value = 0;
            }
            comboBoxSource.SelectedIndex = 0;
            comboBoxDest.SelectedIndex = 0;
            
        }
        public GraphForm(Graph _graph)
        {
            InitializeComponent();
            verticesCount = _graph.VertexCount;
            graph = _graph;
            for (int i = 0; i < verticesCount; i++)
            {
                comboBoxSource.Items.Add(i);
                comboBoxDest.Items.Add(i);
                dataGridViewPaths.Columns.Add(i.ToString(), (i+1).ToString());
                dataGridViewPaths.Columns[i].Width = 30;
                dataGridViewPaths.Rows.Add();
                dataGridViewPaths.Rows[i].HeaderCell.Value = (i+1).ToString();
                dataGridViewPaths.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridViewPaths[i, i].ReadOnly = true;
                dataGridViewPaths[i, i].Value = 0;
            }
            comboBoxSource.SelectedIndex = 0;
            comboBoxDest.SelectedIndex = 0;


            for (int i = 0; i < dataGridViewPaths.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewPaths.ColumnCount; j++)
                {
                    try {
                        if (graph[i, j] != -1)
                            dataGridViewPaths[j, i].Value = graph[i, j, Graph.IndexatorOption.Cost];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Unable to read Graph");
                        throw e;
                    }
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
                int startIdx = Int32.Parse(comboBoxSource.SelectedItem.ToString());
                int endIdx = Int32.Parse(comboBoxDest.SelectedItem.ToString());
                mintiRez = graph.DoMinti(startIdx);

                string filename = "graph.txt";
                string filepath = "C:\\Users\\Smith\\Downloads\\testRusnak";
                System.IO.File.WriteAllText(Path.Combine(filepath, filename), graph.ToDotGraph(startIdx, endIdx, mintiRez, checkBoxShowSingles.Checked));
                GenerateGraph(filename, filepath);
                System.Diagnostics.Process.Start(Path.Combine(filepath, filename.Replace(".txt", ".jpeg")));

            }
            catch (Exception exception) {
                MessageBox.Show("Unable to calculate");
                throw;
            }
        }

        private void ReadGraphFromDataGrid() {
            graph = new Graph(verticesCount);
            for (int i = 0; i < dataGridViewPaths.RowCount; i++) {
                for (int j = 0; j < dataGridViewPaths.ColumnCount; j++) {
                    try {
                        if (dataGridViewPaths[j, i].Value != null)
                            graph[i, j, Graph.IndexatorOption.Cost] =
                                Int32.Parse(dataGridViewPaths[j, i].Value.ToString());
                    }
                    catch (Exception e) {
                        MessageBox.Show("Unable to read Graph");
                        throw e;
                    }
                }
            }
        }

        private static void GenerateGraph(string fileName, string path)
        {
            try
            {
                var command = string.Format("C:\\Users\\Smith\\Downloads\\testRusnak\\graphviz-2.38\\release\\bin\\dot -Tjpeg {0} -o {1}", Path.Combine(path, fileName), Path.Combine(path, fileName.Replace(".txt", ".jpeg")));

                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);

                var proc = new System.Diagnostics.Process();

                proc.StartInfo = procStartInfo;

                proc.Start();

                proc.WaitForExit();

            }
            catch (Exception x)
            {

            }
        }

        private void buttonShowMap_Click(object sender, EventArgs e) {
            if (mintiRez == null) {
                MessageBox.Show("Nothing to show");
                return;
            }
            try
            {
            
                int startIdx = Int32.Parse(comboBoxSource.SelectedItem.ToString());
                int endIdx = Int32.Parse(comboBoxDest.SelectedItem.ToString());

                string filename = "graph.txt";
                string filepath = "C:\\Users\\Smith\\Downloads\\testRusnak";
                System.IO.File.WriteAllText(Path.Combine(filepath, filename), graph.ToDotGraph(startIdx, endIdx, mintiRez, checkBoxShowSingles.Checked));
                GenerateGraph(filename, filepath);
                System.Diagnostics.Process.Start(Path.Combine(filepath, filename.Replace(".txt", ".jpeg")));

            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to show");
                throw;
            }
        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e) {
            if (graph == null) { MessageBox.Show("Nothing to save"); return;}
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                graph.save(saveFileDialog1.FileName);
            }
        }
    }
}
