using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsMinti
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNewGraph_Click(object sender, EventArgs e) {
            int v;
            try {
                v = Int32.Parse(textBoxVertex.Text);
                if (v < 1) throw  new Exception();
            }
            catch (Exception exception) {
                MessageBox.Show("Невірно введена кількість. Доступне додатнє число <=655", "Error");
                return;
            }
            GraphForm gf = new GraphForm(v);
            gf.Show(this);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    GraphForm gf = new GraphForm(Graph.Load(openFileDialog1.FileName));
                    gf.Show(this);
                }
            }
            catch (Exception exception) {
                MessageBox.Show("Неможливо відкрити файл");
#if DEBUG
                throw;
#endif
            }
        }

    }
}
