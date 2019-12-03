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
    public partial class Form_Autoriz : Form
    {
        public Form_Autoriz()
        {
            InitializeComponent();
        }

        private void Form_Autoriz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Пользователи);
            //Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog="Швейное производство v1.1";Integrated Security=True
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, password, role;
            bool flag = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                login = dataGridView1.Rows[i].Cells[1].Value.ToString();
                password = dataGridView1.Rows[i].Cells[2].Value.ToString();
                role = dataGridView1.Rows[i].Cells[3].Value.ToString();

                if(login == textBox1.Text && password == textBox2.Text)
                {
                    dataGridView1.Rows[i].Selected = true;
                    switch (role)
                    {
                        case "Руководитель":
                            flag = !flag;
                            Form_director a = new Form_director();
                            a.Show();
                            break;
                        case "Заказчик":
                            flag = !flag;
                            Form_client b = new Form_client();
                            b.Show();
                            break;
                        case "Кладовщик":
                            flag = !flag;
                            Form_storekeeper c = new Form_storekeeper();
                            c.Show();
                            break;
                        case "Менеджер":
                            flag = !flag;
                            Form_manager d = new Form_manager();
                            d.Show();
                            break;
                    }
                }
                else if(textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                    flag = !flag;
                }
                else if(flag != false)
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                    flag = !flag;
                }
                if (flag)
                {
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Reg f = new Form_Reg();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_manager f = new Form_manager();
            f.Show();
        }
    }
}
