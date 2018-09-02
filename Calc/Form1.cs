using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char[] String2Compute = textBox1.ToString().ToCharArray();
            int[] What2Compute = new int[String2Compute.Length];
            int i = 0;
            while (i < String2Compute.Length)
            {
                What2Compute[i] = (int)(String2Compute[i]);
                i++;
            }

            //What2Compute.Sum;
        }
    }
}
