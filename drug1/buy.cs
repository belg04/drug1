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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void recipeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drugstoreDataSet);

        }

        private void buy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.recipe". При необходимости она может быть перемещена или удалена.
            this.recipeTableAdapter.Fill(this.drugstoreDataSet.recipe);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.выдача_справок_о_продаже_лекарств_за_период_или_на_дату_TableAdapter.Fill(this.drugstoreDataSet4.Выдача_справок_о_продаже_лекарств_за_период_или_на_дату_, ((System.DateTime)(System.Convert.ChangeType(startDateToolStripTextBox.Text, typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(endDateToolStripTextBox.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
