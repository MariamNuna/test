using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();
            string res = s.HelloWorld();
            MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMise_a_jour f = new FormMise_a_jour();
            f.ShowDialog();
        }

        
    }
}
