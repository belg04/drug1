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
    public partial class drug : Form
    {
        public drug()
        {
            InitializeComponent();
        }

        private void drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.drug". При необходимости она может быть перемещена или удалена.
            this.drugTableAdapter.Fill(this.drugstoreDataSet.drug);

        }

        private void name_of_drugLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drugBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drugBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drugBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drugBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drugBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drugBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit(); 
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);
        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
