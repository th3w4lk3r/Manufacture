using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Швейное_производство
{
    public partial class Form_storekeeper : Form
    {
        public Form_storekeeper()
        {
            InitializeComponent();
        }

        private void Form_storekeeper_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Фурнитура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Ткани);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
