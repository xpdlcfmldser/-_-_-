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
using WindowsFormsApp5.Obshaga_30_1_08DataSetTableAdapters;

namespace WindowsFormsApp5
{
    public partial class студенты : Form
    {
        public студенты()
        {
            InitializeComponent();
            
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.obshaga_30_1_08DataSet);

        }

        private void студенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.obshaga_30_1_08DataSet.Students);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (студенты_изменения form = new студенты_изменения())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    studentsTableAdapter.Fill(
                        obshaga_30_1_08DataSet.Students);
                }
                form.nameTextBox.Text = "";
                form.surnameTextBox.Text = "";
                form.telefon_NumberTextBox.Text = "";
                form.midle_NameTextBox.Text = "";
            }


           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.CurrentRow == null ||
                    studentsDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Выберите студента для удаления!");
                return;
            }

            int id = Convert.ToInt32(
                studentsDataGridView.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить студента?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            string connectionString =
                @"Data Source=SERVER30\SQLEXPRESS;Initial Catalog=Obshaga_30_1_08;Integrated Security=True";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    string query =
                        "DELETE FROM Students WHERE ID_Students = @id";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();

                        int count = command.ExecuteNonQuery();

                        if (count > 0)
                        {
                            MessageBox.Show("Студент успешно удалён!");

                            studentsTableAdapter.Fill(
                                obshaga_30_1_08DataSet.Students);
                        }
                        else
                        {
                            MessageBox.Show("Студент не найден!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView row = studentsBindingSource.Current as DataRowView;

            if (row == null)
            {
                MessageBox.Show("Выберите студента для редактирования!");
                return;
            }

            int id = Convert.ToInt32(row[0]);

            using (студенты_изменения form = new студенты_изменения())
            {
                form.EditingStudentId = id;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    studentsTableAdapter.Fill(
                        obshaga_30_1_08DataSet.Students);
                }

            }

          
        }
      
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                studentsBindingSource.Sort = "Name ASC";

            if (comboBox1.SelectedIndex == 1)
                studentsBindingSource.Sort = "Name DESC";

            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                studentsBindingSource.RemoveFilter();
            }
            else
            {
                string name = textBox1.Text.Replace("'", "''")
                    .Replace("[", "[[]")
                    .Replace("%", "[%]")
                    .Replace("*", "[*]");

                studentsBindingSource.Filter =
                    "Name LIKE '%" + name + "%'";
            }
        }
    }
    
}
