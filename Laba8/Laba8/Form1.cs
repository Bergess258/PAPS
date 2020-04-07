using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8
{
    public partial class Form1 : Form
    {
        static Data context = new Data();
        static IMath expression = new Addition(new Number("x"),
                new Substract(new Number("y"), new Number("z")));
        public Form1()
        {
            InitializeComponent();
            context.SetVariable("x", (int)numericUpDown1.Value);
            context.SetVariable("y", (int)numericUpDown2.Value);
            context.SetVariable("z", (int)numericUpDown3.Value);
            count();
        }
        void count()
        {
            label4.Text = "=" + expression.Interpret(context);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            context.SetVariable("x",(int)numericUpDown1.Value);
            count();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            context.SetVariable("y", (int)numericUpDown2.Value);
            count();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            context.SetVariable("z", (int)numericUpDown3.Value);
            count();
        }
    }
}
