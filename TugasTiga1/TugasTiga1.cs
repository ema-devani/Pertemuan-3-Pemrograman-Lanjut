using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class TugasTiga1 : Form
    {
        public TugasTiga1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Visible = true;
            lblNama.Visible = true;
            lblKelas.Visible = true;
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNim.Visible = false;
            lblNama.Visible = false;
            lblKelas.Visible = false;
        }
    }
}
