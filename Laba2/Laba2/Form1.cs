using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ReportBuilder report = new ReportBuilder();
            report.BuildDiagram();
            report.BuildGraphic();
            report.BuildText();
            for (int i = 0; i < report.GetResult().getReport().Count; ++i)
                listView1.Items.Add(report.GetResult().getReport()[i]);
        }
    }
}
