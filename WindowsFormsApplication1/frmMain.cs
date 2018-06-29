using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCHU_Click(object sender, EventArgs e)
        {
            frmCHU fCHU = new frmCHU();
            fCHU.Show();
        }

        private void btnJoinName_Click(object sender, EventArgs e)
        {

            frmTXT ftxt = new frmTXT();
            ftxt.Show();



        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            frmClip fClip = new frmClip();
            fClip.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReName freName = new frmReName();
            freName.Show();
        }
    }
}
