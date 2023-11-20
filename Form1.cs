namespace _Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4;
            double pro;
            cal1 = double.Parse(textBox1.Text);
            cal2 = double.Parse(textBox2.Text);
            cal3 = double.Parse(textBox3.Text);
            cal4 = double.Parse(textBox4.Text);
            pro = (cal1 + cal2 + cal3 + cal4) / 4;
            textBox5.Text = pro.ToString();
            if (cal1 < 6.0 || cal1 < 6.0 || cal3 < 6.0 || cal4 < 6.0)

            {
                MessageBox.Show(" REPROBADO");
            }
            else
    if (pro >= 6.0)
            {
                MessageBox.Show(" APROBADO");
            }
            else
            {
                MessageBox.Show(" REPROBADO");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}