﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarProxy carProxy = new CarProxy();
            label1.Text = carProxy.getFunction("Голосовое управление").getName();
            label2.Text = carProxy.getFunction("Голосовое управление").getName();
            label3.Text = carProxy.cachedCarFunctionsCount().ToString();
        }
    }
}
