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

namespace Traffic_Violations_Var_21
{
    public partial class FormTrafficViolations : Form
    {
        DataSet dataSet;
        SqlDataAdapter dataAdapter;

        public FormTrafficViolations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT C.RegistNumber, C.FirstName, C.LastName, C.Mark, Data, Time, TypeViolation, FineSize " +
                "FROM Fines " +
                "Inner join Cars C on C.Id_Car = Car_Id";

            using (var connection = new SqlConnection(Connection.Connect))
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(query, connection);

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Fines");
                dataVievMain.DataSource = dataSet.Tables[0];
                //dataGridView1.Columns["Name"].ReadOnly = true;

            }
        }

        private void btAddFine_Click(object sender, EventArgs e)
        {
            FormAddFine formAddFine = new FormAddFine();
            DialogResult result = formAddFine.ShowDialog(this);


            if (result == DialogResult.Cancel) return;

            SqlConnection connection = new SqlConnection(Connection.Connect);
            SqlCommand command;
            connection.Open(); 
            command = new SqlCommand( "INSERT INTO Fines (Data, Time, TypeViolation, FineSize, Car_Id)VALUES(@Data, @Time, @TypeViolation, @FineSize, @Car_Id)", connection);

            command.Parameters.AddWithValue("Data", formAddFine.dtpData.Text);
            command.Parameters.AddWithValue("Time", formAddFine.dtpTime.Text);

            command.Parameters.AddWithValue("TypeViolation", formAddFine.cbTypeViolation.Text);
            command.Parameters.AddWithValue("FineSize", formAddFine.nudFineSize.Text);
            command.Parameters.AddWithValue("Car_Id", formAddFine.cbRegNumb.SelectedValue);

            command.ExecuteNonQuery();
        }
    }
}
