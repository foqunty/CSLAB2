namespace CSLAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool CheckPass(int score)
        {
            return score >= 50;
        }
        string LetterGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        int Average(int score)
        {
            return 100 - score;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox1.Text);
            label1.Text = CheckPass(score) ? "Pass" : "Fail";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox1.Text);
            label1.Text = Average(score).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox1.Text);
            label1.Text = LetterGrade(score);

        }
    }
}
