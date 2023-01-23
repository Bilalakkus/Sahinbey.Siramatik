namespace Sahinbey.Siramatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblKayan.Text = "        Þahinbey Belediyesine Hoþ Geldiniz...                                                                   ";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKayan.Text = lblKayan.Text.Substring(2) + lblKayan.Text.Substring(0, 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmploye formEmployee=new FrmEmploye();
        }
    }
}