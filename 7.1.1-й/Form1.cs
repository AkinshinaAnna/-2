using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _7._1._1_й
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = ClassConvert.StrToArray<int>(textBox1.Text);
            ClassArr arrSum = new ClassArr(arr);

            string answer = arrSum.Sum().ToString();
            label2.Text = answer;

        }
    }
}
