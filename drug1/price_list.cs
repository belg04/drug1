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
    public partial class price_list : Form
    {
        public price_list()
        {
            InitializeComponent();
        }

        private void price_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.price_list". При необходимости она может быть перемещена или удалена.
            this.price_listTableAdapter.Fill(this.drugstoreDataSet.price_list);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Price_list_drugs". При необходимости она может быть перемещена или удалена.
            this.price_list_drugsTableAdapter.Fill(this.drugstoreDataSet.Price_list_drugs);

        }
    }
}
