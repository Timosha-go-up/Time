using System;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {

        int second = 59;

        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            second = 10;
           timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
           

           /* if (second < 59)
            {

            second++;
              if (second < 10)
                {
                    label1.Text="0"+second.ToString();
                }
               
              else label1.Text=second.ToString(); 
            }

         
            else {
                second = 0;

                label1.Text = "00";
            }*/
     

            if (second != 0)
            {  

                second--;
                if (second < 10)
                {
                    label1.Text = "0" + second.ToString();
                }

                else label1.Text = second.ToString();
            }


            else
            {
                second = 10;

                label1.Text = "00";
                 timer1.Stop();


                form2 = new Form2();
                form2.ShowDialog();
                Application.Exit();

            }














        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "10";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {

            }
        }
    }
}
