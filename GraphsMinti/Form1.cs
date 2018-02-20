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
                MessageBox.Show("Wrong number of vertices", "Error");
                return;
            }
            GraphForm gf = new GraphForm(v);
            gf.Show(this);
        }
    }
}
