using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Швейное_производство
{
    public partial class Form_Reg : Form
    {
        public Form_Reg()
        {
            InitializeComponent();
        }

        public string s1 = "";
        public string s2 = "";
        public string s21 = "";

        private void Form_Reg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Швейное_производство_v1_1DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Пользователи);
            // Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog="Швейное производство v1.1";Integrated Security=True

        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
             {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Швейное производство v1.1;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();
                
                var cmd = new SqlCommand("INSERT INTO [Пользователи] ([ID], [Login], [Password], [Role]) VALUES (@id,@login, @password, @role)", Conn);
                cmd.Parameters.Add("@id", dataGridView1.RowCount);
                cmd.Parameters.Add("@login", textBox1.Text);
                cmd.Parameters.Add("@password", textBox2.Text);
                cmd.Parameters.Add("@role", "Заказчик");

                cmd.ExecuteNonQuery();
                this.пользователиTableAdapter.Fill(this._Швейное_производство_v1_1DataSet.Пользователи);

                MessageBox.Show("Регистрация завершена");

             }
             catch
             {
                MessageBox.Show("Не получилось");
             }
            
           
        }
    }
}
