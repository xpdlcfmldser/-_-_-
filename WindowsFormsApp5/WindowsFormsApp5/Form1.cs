using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        
        }


        public void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SERVER30\\SQLEXPRESS;Initial Catalog=Obshaga_30_1_08;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Logins " +
                  "WHERE Login = @Login AND Parol = @Password";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

      

            sqlCommand.Parameters.AddWithValue("@Login", textbox_login.Text);
            sqlCommand.Parameters.AddWithValue("@Password", textbox_parol.Text);

            // ExecuteScalar вернёт количество найденных строк
            int count = (int)sqlCommand.ExecuteScalar();
            if (count > 0)
            {
                Form form = new Меню();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка. Повторите попытку");
            }

            sqlConnection.Close();


        }
            
            

        private void gruppsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruppsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.obshaga_30_1_08DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Grupps". При необходимости она может быть перемещена или удалена.
            this.gruppsTableAdapter.Fill(this.obshaga_30_1_08DataSet.Grupps);

        }
    }
}
