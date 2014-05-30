using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapeleriaALONDRA
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void submenu_articulos_Click(object sender, EventArgs e)
        {
            Frm_Articulos FArt = new Frm_Articulos();
            FArt.MdiParent = this;
            FArt.Show();
        }
    }
}
