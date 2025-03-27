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
    public partial class medications_received : Form
    {
        public medications_received()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.функция_поступивших_за_заданный_период_времениTableAdapter.Fill(this.drugstoreDataSet2.функция_поступивших_за_заданный_период_времени, ((System.DateTime)(System.Convert.ChangeType(startDateToolStripTextBox.Text, typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(endDateToolStripTextBox.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
