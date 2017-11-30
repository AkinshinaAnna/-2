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

namespace _6._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string str = InputTextBox.Text;

            ClassString cs = new ClassString(str);

            string answer = cs.CountWordsWithA().ToString();
            OutputTextLabel.Text = answer;
            
        }
    }
}
