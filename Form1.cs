namespace CSharp_GiaiPTBac2
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        double x1;
        double x2;
        double dental;
        public Form1()
        {
            InitializeComponent();
        }
        private void LayThongTin()
        {
            try
            {
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);
                c = Convert.ToInt32(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
                txtB.Clear();
                txtC.Clear();
            }
        }
        private void GPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    lblKQ1.Text = lblKQ2.Text = ("Phương trình vô số nghiệm");
                }
                else
                {
                    lblKQ1.Text = lblKQ2.Text = ("Phương trình vô nghiệm");
                }
            }
            else
            {
                lblKQ1.Text = lblKQ2.Text = ($"Nghiệm là " + Math.Round((-b / a), 2));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LayThongTin();
            if (a == 0)
            {
                GPTBac1(b, c);
            }
            else
            {
                dental = (double)Math.Pow(b, 2) - 4 * a * c;
                lblDT.Text = dental.ToString();
            }
            if (dental < 0)
            {
                lblKQ1.Text = ("Phương trình vô nghiệm");
            }
            if (dental == 0)
            {
                lblKQ1.Text = lblKQ2.Text = ($"Nghiệm là " + Math.Round((double)(-b / 2 * a), 2));

            }
            if (dental > 0)
            {
                // phương trình có 2 nghiệm phân biệt.
                x1 = (double)(-b + Math.Sqrt(dental)) / (2 * a);
                x2 = (double)(-b - Math.Sqrt(dental)) / (2 * a);
                lblKQ1.Text = x1.ToString();
                lblKQ2.Text = x2.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
