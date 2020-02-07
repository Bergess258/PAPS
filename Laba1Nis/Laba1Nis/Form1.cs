﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Nis
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        public Form1()
        {
            InitializeComponent();
            foreach (AbstractFactory t in client.getFactories())
                listView1.Items.Add(t.Produce().Info());
        }
    }
}
