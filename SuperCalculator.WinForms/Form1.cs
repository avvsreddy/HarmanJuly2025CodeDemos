using SuperCalculator.Business;

namespace SuperCalculator.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fno = int.Parse(textBox1.Text);
            int sno = int.Parse(textBox2.Text);
            ICalculator calc = new Calculator(); // DIP
            int sum = calc.FindSum(fno, sno);
            MessageBox.Show($"The sum of {fno} and {sno} is {sum}");
        }
    }
}
