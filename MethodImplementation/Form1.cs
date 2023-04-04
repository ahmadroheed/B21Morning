using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // access_specifier return_type method_name (parameter_list)


        // with out parameter without return type

        public void show()
        {
            MessageBox.Show("This is an example of simple method.");
        }

        public void sumNumber(double a , double b)
        {
            double result = a + b;
            MessageBox.Show(result.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show();
            try
            {
                string n1 = textBoxNumber1.Text;
                string n2 = textBoxNumber2.Text;

                double x = double.Parse(n1);
                double y = double.Parse(n2);


                sumNumber(x, y);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }
    }
}
