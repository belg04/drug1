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
    public partial class manual : Form
    {
        public manual()
        {
            InitializeComponent();
        }

        private void drug2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.drug". При необходимости она может быть перемещена или удалена.
            this.drugTableAdapter.Fill(this.drugstoreDataSet.drug);

        }

        private void drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           drug sf = new drug(); 
            sf.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            provider sf = new provider();
            sf.Show();
        }
    }
}
