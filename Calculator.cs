using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    
    public partial class Form1 : Form
    {
        string real1, real2, imag1, imag2;
        double resultreal, resultimag;
        double r1, r2, i1, i2;
     
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e) //no need of this function
        {
            
        }

        private void label2_Click(object sender, EventArgs e)//no need of this function
        {

        }

        private void label3_Click(object sender, EventArgs e) //no need of this function
        {

        }

        private void real_no1_TextChanged(object sender, EventArgs e)
        {
            real1 = this.real_no1.Text; //taking input from real no of operand 1
            if(real1.Contains('a'))
            {
                MessageBox.Show(
                               "your message",
                               "window title",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk); //For Info Asterisk
                                                          //For triangle Warning )
            }

        }

        private void imag_no1_TextChanged(object sender, EventArgs e)
        {
            imag1 = this.imag_no1.Text;  //taking input from imaginary no of operand 2
        }

        private void real_no2_TextChanged(object sender, EventArgs e)
        {
            real2 = this.real_no2.Text;  //taking input from imaginary no of operand 1
        }

        private void imag_no2_TextChanged(object sender, EventArgs e)
        {
            imag2 = this.imag_no2.Text;  //taking input from real no of operand 2

        }

        public void Change()                              //changing the string value into double with signs so that calculations can be done
        {
            r1 = (double.Parse(real1.Substring(1)));
            r2 = (double.Parse(real2.Substring(1)));
            i1 = (double.Parse(imag1.Substring(1)));
            i2 = (double.Parse(imag2.Substring(1)));
            if (real1[0].Equals('-'))
            {
                r1 = -(r1);
            }
            if (real2[0].Equals('-'))
            {
                r2 = -(r2);
            }
            if (imag1[0].Equals('-'))
            {
                i1 = -(i1);
            }
            if (imag2[0].Equals('-'))
            {
                i2 = -(i2);
            }

        }
        private void label4_Click(object sender, EventArgs e) //no need 
        {

        }
        private void ADD_Click(object sender, EventArgs e)  //adding of complex no
        {
            Change();                            //calling change function to change into double
            resultreal = r1 + r2;
            resultimag = i1 + i2;

        }

        private void SUBTRACT_Click(object sender, EventArgs e)   //subtracting complex nos
        {
            Change();
            resultreal = r1 - r2;
            resultimag = i1 - i2;
            
        }

        private void MULTIPLY_Click(object sender, EventArgs e)   //multiplying complex nos
        {
            Change();
            resultreal = (r1 * r2) - (i1 * i2);
            resultimag = r1 * i2 + i1 * r2;
            
        }

        private void label9_Click(object sender, EventArgs e)  //no need of this 
        {

        }
        
        

        private void DIVIDE_Click(object sender, EventArgs e)         //dividing complex nos
        {
            resultreal = ((r1 * r2) + (i1 * i2))/(r2*r2-i2*i2);
            resultimag= ((i1 * r2) - (i2 * r1)) / (r2 * r2 - i2 * i2);
            
        }

        private void CALCULATE_Click(object sender, EventArgs e)    //will display the result
        {
            Real_no3.Text = Convert.ToString(resultreal);
            Imag_no3.Text = Convert.ToString(resultimag);
        }


        private void CLEAR_Click(object sender, EventArgs e)  //clear the values 
        {
            real_no1.Text = string.Empty;
            real_no2.Text = string.Empty;
            imag_no1.Text = string.Empty;
            imag_no2.Text = string.Empty;
            Real_no3.Text = string.Empty;
            Imag_no3.Text = string.Empty;
        }

    }
}
