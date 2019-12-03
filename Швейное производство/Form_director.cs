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
    public partial class Form_director : Form
    {
        public Form_director()
        {
            InitializeComponent();
        }

        private void Form_director_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Изделие". При необходимости она может быть перемещена или удалена.
            this.изделиеTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Изделие);

        }
    }
}
