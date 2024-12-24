using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form2 : Form
    {
        Form1 f1;
        int a = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (label1.Visible)
            {
            timer1.Start();
            a = 6;
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           


        }

        private void timer1_Tick(object sender, EventArgs e)
                 
        { 
            a--;
           
           

            if (a == 0)
            {

                timer1.Stop();

               Close();


                

            }

           
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
          

        }

        private void label1_EnabledChanged(object sender, EventArgs e)
        {

         
        }
    }
}
