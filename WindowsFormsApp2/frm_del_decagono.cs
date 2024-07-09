using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_del_decagono : Form
    {
        private Decagono_lineas ObjCDecagon = new Decagono_lineas();
        public frm_del_decagono()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ObjCDecagon.ReadData(txtA);
            ObjCDecagon.PlotShape(picCanvas);

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCDecagon.InitializeData();
            ObjCDecagon.InitializeControls(txtA, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDecagon_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}