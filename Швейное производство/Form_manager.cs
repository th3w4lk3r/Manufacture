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
    public partial class Form_manager : Form
    {
        public Form_manager()
        {
            InitializeComponent();
        }

        private void Form_manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Изделие". При необходимости она может быть перемещена или удалена.
            this.изделиеTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Изделие);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_list_of_order f = new Form_list_of_order();
            f.Show();
        }
    }
}
