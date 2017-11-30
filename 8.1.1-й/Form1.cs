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

namespace _8._1._1_й
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = ClassConvert.StrToList<int>(InputListtextBox1.Text);
            ClassList changedlist = new ClassList(list);
            changedlist.Process();

            OutputListlabel.Text = ClassConvert.ListToStr(list, " ");


        }
    }
}
