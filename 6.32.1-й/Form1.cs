using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using BL;

namespace _6._32._1_й
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Callculatebutton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(InputXtextBox.Text);
            double E = double.Parse(InputEtextBox.Text);

            ClassCycle o = new ClassCycle(x);

            
            string answer = "Ответ: " + Environment.NewLine;
            answer += "Точная сумма: " + o.LeftCalculate() + Environment.NewLine;
            answer += "Сумма N слагаемых = " + o.RightCalculateSum(E) + Environment.NewLine;
            answer += "Количество слагаемых = " + o.RightCalculateCount( E) + Environment.NewLine;


            AnswerLbl.Text = answer;
        }


    }
}
