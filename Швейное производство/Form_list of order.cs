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
    public partial class Form_list_of_order : Form
    {
        public Form_list_of_order()
        {
            InitializeComponent();
        }

        private void Form_list_of_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Заказ);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = dataGridView1.CurrentCell.RowIndex;
            string status = dataGridView1.Rows[selectRow].Cells[2].Value.ToString();
            

            switch(status)
            {
                case "Новый":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "Ожидает":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "Обработка":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "К оплате":
                    comboBox1.SelectedIndex = 3;
                    break;
                case "Оплачен":
                    comboBox1.SelectedIndex = 4;
                    break;
                case "Раскрой":
                    comboBox1.SelectedIndex = 5;
                    break;
                case "Готов":
                    comboBox1.SelectedIndex = 6;
                    break;
                case "Отклюнен":
                    comboBox1.SelectedIndex = 7;
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = Convert.ToString(comboBox1.SelectedItem);

        }
    }
}
