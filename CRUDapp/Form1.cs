using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;
namespace CRUDapp
{//form1
    public partial class Form1 : Form
    {
        private string connectionString = "server=DESKTOP-JSQU9PD;user=root1;password=root2;database=CRUDapp";
        private DataTable userTable;
        private MySqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            userTable = new DataTable();

            dataGridView1.DataSource = userTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   // insert operation 
        {
            int id;
            string name;
            int age;

            try
            {

                id = int.Parse(textBox1.Text);
                name = textBox2.Text;
                age = int.Parse(textBox3.Text);


                string insertQuery = $"INSERT INTO UserTab (ID, Name, Age) VALUES (@id, @name, @age)";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);


                    command.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully!");
                    LoadUserData();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please enter valid integers for ID and Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)// check connection button used to check the connections 
        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) // delete button which delteds all selected rows
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                string deleteQuery = $"DELETE FROM UserTab WHERE ID = @id";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                            LoadUserData(); // Reload data after delete
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted. Please check the selected row and try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void LoadUserData() // function used to display all the present data
        {
            userTable.Clear(); // Clear existing data

            string selectQuery = "SELECT * FROM UserTab";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    adapter = new MySqlDataAdapter(selectQuery, connection);

                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)// used to update the value based on the selection of the connections 
        {
            if (dataGridView1.SelectedRows.Count == 1) //check if a row is selected
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()); //Get ID from selected row
                string name = textBox2.Text;
                int age = int.Parse(textBox3.Text);

                string updateQuery = $"UPDATE UserTab SET Name = @name, Age = @age WHERE ID = @id";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@age", age);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            LoadUserData(); //reload data after update
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check the selected row and try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

    }
}
