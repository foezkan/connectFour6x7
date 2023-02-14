using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectFour6x7
{

    public partial class Form1 : Form
    {
        int i = 0, schalter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
    

        private void button10_Click_1(object sender, EventArgs e)
        {
           
           

            if (schalter % 2 == 0)
            {
                button10.BackColor= Color.Red;
            }
            else 
            {
                button10.BackColor = Color.Yellow;
            }
             schalter++;

          
            if (btn6.BackColor!= Color.Red && btn6.BackColor!=Color.Yellow) 
            { 
            btn6.BackColor = button10.BackColor;
            }
            else if (btn5.BackColor != Color.Red && btn5.BackColor != Color.Yellow) 
            {
                btn5.BackColor = button10.BackColor;
            }


            else if (btn4.BackColor != Color.Red && btn4.BackColor != Color.Yellow)
            {
                btn4.BackColor = button10.BackColor;
            }

            else if (btn3.BackColor != Color.Red && btn3.BackColor != Color.Yellow)
            {
                btn3.BackColor = button10.BackColor;
            }

            else if (btn2.BackColor != Color.Red && btn2.BackColor != Color.Yellow)
            {
                btn2.BackColor = button10.BackColor;
            }

            else if (btn1.BackColor != Color.Red && btn1.BackColor != Color.Yellow)
            {
                btn1.BackColor = button10.BackColor;
            }

            else if (btn1.BackColor == Color.Red || btn1.BackColor == Color.Yellow)
            {
                button10.Enabled = false;
                schalter--;
                button10.BackColor = Color.Gray;

            }


            //

            if (button10.BackColor == Color.Red)
            {
                button10.BackColor = Color.Yellow;
            }
            else
            {
                button10.BackColor = Color.Red;
            }

        }

        
    }
}
