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
    public partial class PatientInformation : Form
    {
        public PatientInformation()
        {
            InitializeComponent();
        }
        //After user inputs the desired last name, it will query the DB with patient information and output it to the form 
        private void PatInfo_SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (PatInfo_SearchPatientFirstNameTxtBox.Text == "")
                {
                    cmd.CommandText = "select * from PatientInfo where patientlastname = '" + PatInfo_SearchPatientLastNameTxtBox.Text + "'";
                }
                else if (PatInfo_SearchPatientLastNameTxtBox.Text == "")
                {
                    cmd.CommandText = "select * from PatientInfo where patientfirstname = '" + PatInfo_SearchPatientFirstNameTxtBox.Text + "'";
                }
                else if (PatInfo_SearchPatientFirstNameTxtBox.Text != null && PatInfo_SearchPatientLastNameTxtBox.Text != null)
                {
                    cmd.CommandText = "select * from PatientInfo where patientfirstname = '" + PatInfo_SearchPatientFirstNameTxtBox.Text + "' and patientlastname = '" + PatInfo_SearchPatientLastNameTxtBox.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //Form fields will be filled with database values, specified below
                PatInfo_FirstNameField.Text = ds.Tables[0].Rows[0][1].ToString();
                PatInfo_LastNameField.Text = ds.Tables[0].Rows[0][2].ToString();
                PatInfo_UsernameField.Text = ds.Tables[0].Rows[0][3].ToString();
                PatInfo_PasswordField.Text = ds.Tables[0].Rows[0][4].ToString();
                PatInfo_DOBField.Text = ds.Tables[0].Rows[0][10].ToString();
                PatInfo_RoomNumberField.Text = ds.Tables[0].Rows[0][5].ToString();
                PatInfo_RoomTypeField.Text = ds.Tables[0].Rows[0][6].ToString();
                PatInfo_GenderField.Text = ds.Tables[0].Rows[0][7].ToString();
                PatInfo_AgeField.Text = ds.Tables[0].Rows[0][8].ToString();
                PatInfo_PhoneNumberField.Text = ds.Tables[0].Rows[0][9].ToString();
                con.Close();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Patient not found in database.");
            }
        }

        private void PatInfo_DeletePatientBtn_Click(object sender, EventArgs e)
        {
            //I added a message box to verify that the user truly wants to delete someone
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this patient?", "Please select an action", MessageBoxButtons.OKCancel);
            if (confirmation == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (PatInfo_SearchPatientFirstNameTxtBox.Text == "")
                {
                    cmd.CommandText = "delete from PatientInfo where patientlastname = '" + PatInfo_SearchPatientLastNameTxtBox.Text + "'";
                }
                else if (PatInfo_SearchPatientLastNameTxtBox.Text == "")
                {
                    cmd.CommandText = "delete from PatientInfo where patientfirstname = '" + PatInfo_SearchPatientFirstNameTxtBox.Text + "'";
                }
                else if (PatInfo_SearchPatientFirstNameTxtBox.Text != null && PatInfo_SearchPatientLastNameTxtBox.Text != null)
                {
                    cmd.CommandText = "delete from PatientInfo where patientfirstname = '" + PatInfo_SearchPatientFirstNameTxtBox.Text + "' and patientlastname = '" + PatInfo_SearchPatientLastNameTxtBox.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                MessageBox.Show("Patient has been deleted!");
            }
        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select patientfirstname from PatientInfo";
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotext.Add(sdr.GetString(0));
            }
            PatInfo_SearchPatientFirstNameTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            PatInfo_SearchPatientFirstNameTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PatInfo_SearchPatientFirstNameTxtBox.AutoCompleteCustomSource = autotext;
            con.Close();
        }

        private void PatInfo_ResetBtn_Click(object sender, EventArgs e)
        {
            PatInfo_SearchPatientFirstNameTxtBox.Text = "";
            PatInfo_SearchPatientLastNameTxtBox.Text = "";
            PatInfo_FirstNameField.Text = "_________";
            PatInfo_LastNameField.Text = "_________";
            PatInfo_UsernameField.Text = "_________";
            PatInfo_PasswordField.Text = "_________";
            PatInfo_DOBField.Text = "_________";
            PatInfo_RoomNumberField.Text = "_________";
            PatInfo_RoomTypeField.Text = "_________";
            PatInfo_GenderField.Text = "_________";
            PatInfo_AgeField.Text = "_________";
            PatInfo_PhoneNumberField.Text = "_________";
        }
    }
}
