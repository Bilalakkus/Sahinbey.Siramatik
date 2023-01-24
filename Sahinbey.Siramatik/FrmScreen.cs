using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahinbey.Siramatik
{
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer3.Enabled = true;
            lblKayan.Text = "        ŞAHİNBEY BELEDİYESİNE HOŞ GELDİNİZ...                                                                   ";

        }

        private void FrmScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
            lblSaat.Text = DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes + ":" + DateTime.Now.TimeOfDay.Seconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pnlFirst.BackColor = pnlFirst.BackColor == Color.Red ? Color.White : Color.Red;
        }
    }
}
