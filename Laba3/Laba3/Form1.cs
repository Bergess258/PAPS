using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel topMenu = new Panel("Верхнее меню");
            topMenu.Add(new Button("Домой"));
            topMenu.Add(new InputText("Логин"));
            Panel MainPage = new Panel("Главная страница");
            MainPage.Add(topMenu);
            MainPage.Add(new Button("Купить"));
            label1.Text = MainPage.Display(0);
        }
    }
}
