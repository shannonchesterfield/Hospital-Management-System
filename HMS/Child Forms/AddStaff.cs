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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void PatRegistration_ResetBtn_Click(object sender, EventArgs e)
        {
            AddStaff_IDNumberTxtBox.Text = "";
            AddStaff_FirstNameTxtBox.Text = "";
            AddStaff_LastNameTxtBox.Text = "";
            AddStaff_SpecializationTxtBox.Text = "";
            AddStaff_MedicalCredsTxtBox.Text = "";
            AddStaff_UsernameTxtBox.Text = "";
            AddStaff_PasswordTxtBox.Text = "";
            AddStaff_GenderComboBox.Text = "";
            AddStaff_EmailTxtBox.Text = "";
        }

        private void PatRegistration_SubmitBtn_Click(object sender, EventArgs e)
        {
            int idNumber = Convert.ToInt32(AddStaff_IDNumberTxtBox.Text);
            String firstname = AddStaff_FirstNameTxtBox.Text;
            String lastname = AddStaff_LastNameTxtBox.Text;
            String spec = AddStaff_SpecializationTxtBox.Text;
            String mdcreds = AddStaff_MedicalCredsTxtBox.Text;
            String username = AddStaff_UsernameTxtBox.Text;
            String password = AddStaff_PasswordTxtBox.Text;
            String gender = AddStaff_GenderComboBox.Text;
            String email = AddStaff_EmailTxtBox.Text;



            SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into StaffInfo (staffID, stafffirstname, stafflastname, email, specialization, gender, medicalcredentials, staffusername, staffpassword) values (" + idNumber + ",'" + firstname + "','" + lastname + "','" + email + "','" + spec + "','" + gender + "','" + mdcreds + "','" + username + "','" + password + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Staff Added!");
        }
        
    }
}
