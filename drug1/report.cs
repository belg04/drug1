using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drug1
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Expired_drug sf = new Expired_drug(); 
            sf.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            medications_received sf = new medications_received();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            available_remaining_medicines sf = new available_remaining_medicines();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            medicines_by_category sf = new medicines_by_category();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            buy sf = new buy();
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            price_list sf = new price_list();
            sf.Show();
        }
    }
}
