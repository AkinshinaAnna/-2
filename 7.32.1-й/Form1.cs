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

namespace _7._32._1_й
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = ClassConvert.StrToArray<int>(ArrTextBox.Text);
            ClassArr arrNegNumber = new ClassArr(arr);

            string answer = arrNegNumber.NegativeNumber().ToString();
            label2.Text = answer;


        }
    }
}
