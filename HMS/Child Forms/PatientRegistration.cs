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

namespace HMS.Child_Forms
{
    public partial class PatientRegistration : Form
    {
        
        public PatientRegistration()
        {
            InitializeComponent();
        }

        

        private void PatRegistration_SubmitBtn_Click(object sender, EventArgs e)
        {
            String firstName = FirstNameTxtBox.Text;
            String lastName = LastNameTxtBox.Text;
            String username = PatRegistration_UsernameTxtBox.Text;
            String password = PatRegistration_PasswordTxtBox.Text;
            String dob = dateTimePickerDOB.Value.ToShortDateString();
            Int32 roomNumber = Convert.ToInt32(RoomNumberTxtBox.Text);
            String roomType = RoomTypeComboBox.Text;
            String gender = GenderComboBox.Text;
            int age = Convert.ToInt32(AgeTxtBox.Text);
            Int64 phoneNumber = Convert.ToInt64(PhoneNumberMaskedTxtBox.Text);

            SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PatientInfo (patientfirstname, patientlastname, username, password, roomnumber, roomtype, gender, age, phonenumber, dob) values ('"+ firstName +"', '"+ lastName +"', '"+ username +"', '"+ password +"', "+ roomNumber +", '"+ roomType +"', '"+ gender +"', "+ age +", "+ phoneNumber +", '"+ dob +"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Patient Registered!");


        }

        private void PatRegistration_ResetBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Text = "";
            LastNameTxtBox.Text = "";
            PatRegistration_UsernameTxtBox.Text = "";
            PatRegistration_PasswordTxtBox.Text = "";
            RoomNumberTxtBox.Text = "";
            RoomTypeComboBox.Text = "";
            GenderComboBox.Text = "";
            AgeTxtBox.Text = "";
            PhoneNumberMaskedTxtBox.Text = "";
        }
    }
}
