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
    public partial class provider : Form
    {
        public provider()
        {
            InitializeComponent();
        }

        private void dealerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dealerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);

        }

        private void provider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.dealer". При необходимости она может быть перемещена или удалена.
            this.dealerTableAdapter.Fill(this.drugstoreDataSet.dealer);

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealerBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dealerBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dealerBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dealerBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dealerBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dealerBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate(); 
            this.dealerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);
        }
    }
}
