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
                btnFarbe.BackColor= Color.Red;
            }
            else 
            {
                btnFarbe.BackColor = Color.Yellow;
            }
            schalter++;
            

            if (btn6.BackColor!= Color.Red && btn6.BackColor!=Color.Yellow) 
            { 
            btn6.BackColor = btnFarbe.BackColor;
            }
        else if (btn5.BackColor != Color.Red && btn5.BackColor != Color.Yellow) 
            {
                btn5.BackColor = btnFarbe.BackColor;
            }
              
        }

        
    }
}
