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
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.generateDetailedReceiptTableAdapter.Fill(this.drugstoreDataSet7.GenerateDetailedReceipt, ((int)(System.Convert.ChangeType(saleIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void generateDetailedReceiptDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
