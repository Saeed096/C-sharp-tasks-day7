using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form    // as u declare class form1 by yourself inheriting from form class to customize this form1 class finally pass obj from it to run
    {
        public Form1()
        {
            //Text = "saeed";
            InitializeComponent();  // u can write inside designer >> in initialize compononent or here after initialize ... to has effect
                                    //this.BackColor = Color.Red;   // getting red prop from color strcut >> set it to backcolor prop which is in class form
            //this.Load += button1_Click;  
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            if (meterToKilometerBtn.Checked) 
            {
                result = double.Parse(valueTextBox.Text) / 1000;
                this.resultTextBox.Text = result.ToString();
            }
            else if(meterToMileBtn.Checked) 
            {
                result = double.Parse(valueTextBox.Text) * 0.000621371;
                this.resultTextBox.Text = result.ToString();
            }

            else if (mileToMeterBtn.Checked)
            {
                result = double.Parse(valueTextBox.Text) / 0.000621371;
                this.resultTextBox.Text = result.ToString();
            }
            //BackColor = Color.Green;
        }

       
    }
}
