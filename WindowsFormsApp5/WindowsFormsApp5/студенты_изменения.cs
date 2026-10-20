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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp5
{
    public partial class студенты_изменения : Form
    {
        public студенты_изменения()
        {
            InitializeComponent();
            
        }


        public int? EditingStudentId { get; set; } = null;



        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.obshaga_30_1_08DataSet);

        }

        private void студенты_изменения_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.obshaga_30_1_08DataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Grupps". При необходимости она может быть перемещена или удалена.
            this.gruppsTableAdapter.Fill(this.obshaga_30_1_08DataSet.Grupps);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Komnats". При необходимости она может быть перемещена или удалена.
            this.komnatsTableAdapter.Fill(this.obshaga_30_1_08DataSet.Komnats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "obshaga_30_1_08DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.obshaga_30_1_08DataSet.Students);
        
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            telefon_NumberTextBox.Text = "";
            midle_NameTextBox.Text = "";

            LoadStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            telefon_NumberTextBox.Text = "";
            midle_NameTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(surnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(midle_NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(telefon_NumberTextBox.Text))
            {
                MessageBox.Show("Заполните все текстовые поля!");
                return;
            }

            if (nomer_KomnatyComboBox.SelectedIndex < 0 ||
                name_GruppaComboBox.SelectedIndex < 0 ||
                name_InventarComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите комнату, группу и инвентарь!");
                return;
            }

            string connectionString =
                @"Data Source=SERVER30\SQLEXPRESS;Initial Catalog=Obshaga_30_1_08;Integrated Security=True";

            string query;

            if (EditingStudentId.HasValue)
            {
                query = @"UPDATE Students
                  SET Name = @name,
                      Surname = @surname,
                      Midle_Name = @middleName,
                      Telefon_Number = @phone,
                      Komnata_ID = @komnataId,
                      Gruppa_ID = @gruppaId,
                      Inventar_ID = @inventarId
                  WHERE ID_Students = @id";
            }
            else
            {
                query = @"INSERT INTO Students
                  (Name, Surname, Midle_Name,
                   Telefon_Number, Komnata_ID,
                   Gruppa_ID, Inventar_ID)
                  VALUES
                  (@name, @surname, @middleName,
                   @phone, @komnataId,
                   @gruppaId, @inventarId)";
            }

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@name", nameTextBox.Text.Trim());

                    command.Parameters.AddWithValue(
                        "@surname", surnameTextBox.Text.Trim());

                    command.Parameters.AddWithValue(
                        "@middleName", midle_NameTextBox.Text.Trim());

                    command.Parameters.AddWithValue(
                        "@phone", telefon_NumberTextBox.Text.Trim());

                    command.Parameters.AddWithValue(
                        "@komnataId",
                        Convert.ToInt32(nomer_KomnatyComboBox.SelectedValue));

                    command.Parameters.AddWithValue(
                        "@gruppaId",
                        Convert.ToInt32(name_GruppaComboBox.SelectedValue));

                    command.Parameters.AddWithValue(
                        "@inventarId",
                        Convert.ToInt32(name_InventarComboBox.SelectedValue));

                    if (EditingStudentId.HasValue)
                    {
                        command.Parameters.AddWithValue(
                            "@id", EditingStudentId.Value);
                    }

                    connection.Open();

                    int count = command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show(EditingStudentId.HasValue
                            ? "Данные студента успешно изменены!"
                            : "Студент успешно добавлен!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена или не сохранена!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        

        private void LoadStudent()
        {
            if (!EditingStudentId.HasValue)
                return;

            string connectionString =
                @"Data Source=SERVER30\SQLEXPRESS;Initial Catalog=Obshaga_30_1_08;Integrated Security=True";

            string query =
                @"SELECT Name, Surname, Midle_Name,
                 Telefon_Number, Komnata_ID,
                 Gruppa_ID, Inventar_ID
          FROM Students
          WHERE ID_Students = @id";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@id", EditingStudentId.Value);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nameTextBox.Text = reader["Name"].ToString();
                        surnameTextBox.Text = reader["Surname"].ToString();
                        midle_NameTextBox.Text =
                            reader["Midle_Name"].ToString();

                        telefon_NumberTextBox.Text =
                            reader["Telefon_Number"].ToString();

                        nomer_KomnatyComboBox.SelectedValue =
                            reader["Komnata_ID"];

                        name_GruppaComboBox.SelectedValue =
                            reader["Gruppa_ID"];

                        name_InventarComboBox.SelectedValue =
                            reader["Inventar_ID"];
                    }
                }
            }
        }

    }
}

