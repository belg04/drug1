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
    public partial class Expired_drug : Form
    {
        public Expired_drug()
        {
            InitializeComponent();
        }

        private void Expired_drug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drugstoreDataSet.Закончившиеся_лекарства". При необходимости она может быть перемещена или удалена.
            this.закончившиеся_лекарстваTableAdapter.Fill(this.drugstoreDataSet.Закончившиеся_лекарства);

        }
    }
}
