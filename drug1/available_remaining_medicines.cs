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
    public partial class available_remaining_medicines : Form
    {
        public available_remaining_medicines()
        {
            InitializeComponent();
        }

        private void available_remaining_medicines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet5.остаток_лекарств". При необходимости она может быть перемещена или удалена.
            this.остаток_лекарствTableAdapter.Fill(this.drugstoreDataSet5.остаток_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Закончившиеся_лекарства". При необходимости она может быть перемещена или удалена.
            this.закончившиеся_лекарстваTableAdapter.Fill(this.drugstoreDataSet.Закончившиеся_лекарства);

        }
    }
}
