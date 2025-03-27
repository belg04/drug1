using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drug1
{
    public partial class operations : Form
    {
        public operations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            check sf = new check(); 
            sf.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sale sf = new sale(); 
            sf.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            shipmentcs sf = new shipmentcs(); 
            sf.Show();
        }
    }
}
