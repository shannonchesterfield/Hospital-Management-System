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
    public partial class StaffInformation : Form
    {
        public StaffInformation()
        {
            InitializeComponent();
        }

        private void StaffInfo_SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (StaffInfo_SearchStaffFirstNameTxtBox.Text == "")
                {
                    cmd.CommandText = "select * from StaffInfo where stafflastname = '" + StaffInfo_SearchStaffLastNameTxtBox.Text + "'";
                }
                else if (StaffInfo_SearchStaffLastNameTxtBox.Text == "")
                {
                    cmd.CommandText = "select * from StaffInfo where stafffirstname = '" + StaffInfo_SearchStaffFirstNameTxtBox.Text + "'";
                }
                else if (StaffInfo_SearchStaffFirstNameTxtBox.Text != null && StaffInfo_SearchStaffLastNameTxtBox.Text != null)
                {
                    cmd.CommandText = "select * from StaffInfo where stafffirstname = '" + StaffInfo_SearchStaffFirstNameTxtBox.Text + "' and stafflastname = '" + StaffInfo_SearchStaffLastNameTxtBox.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //Form fields will be filled with database values, specified below
                StaffInfo_IDNumberField.Text = ds.Tables[0].Rows[0][1].ToString();
                StaffInfo_FirstNameField.Text = ds.Tables[0].Rows[0][2].ToString();
                StaffInfo_LastNameField.Text = ds.Tables[0].Rows[0][3].ToString();
                StaffInfo_SpecializationField.Text = ds.Tables[0].Rows[0][5].ToString();
                StaffInfo_MedicalCredsField.Text = ds.Tables[0].Rows[0][7].ToString();
                StaffInfo_UsernameField.Text = ds.Tables[0].Rows[0][8].ToString();
                StaffInfo_PasswordField.Text = ds.Tables[0].Rows[0][9].ToString();
                StaffInfo_GenderField.Text = ds.Tables[0].Rows[0][6].ToString();
                StaffInfo_EmailField.Text = ds.Tables[0].Rows[0][4].ToString();
                con.Close();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Staff not found in database.");
            }
        }
        private void StaffInfo_DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this Staff Member?", "Please select an action", MessageBoxButtons.OKCancel);
            if (confirmation == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (StaffInfo_SearchStaffFirstNameTxtBox.Text == "")
                {
                    cmd.CommandText = "delete from StaffInfo where stafflastname = '" + StaffInfo_SearchStaffLastNameTxtBox.Text + "'";
                }
                else if (StaffInfo_SearchStaffLastNameTxtBox.Text == "")
                {
                    cmd.CommandText = "delete from StaffInfo where stafffirstname = '" + StaffInfo_SearchStaffFirstNameTxtBox.Text + "'";
                }
                else if (StaffInfo_SearchStaffFirstNameTxtBox.Text != null && StaffInfo_SearchStaffLastNameTxtBox.Text != null)
                {
                    cmd.CommandText = "delete from StaffInfo where stafffirstname = '" + StaffInfo_SearchStaffFirstNameTxtBox.Text + "' and stafflastname = '" + StaffInfo_SearchStaffLastNameTxtBox.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                MessageBox.Show("Staff Member has been deleted!");
            }
        }

        private void StaffInformation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
            SqlCommand first = con.CreateCommand();
            first.CommandText = "select stafffirstname from StaffInfo";
            con.Open();
            SqlDataReader sdrfirst = first.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdrfirst.Read())
            {
                autotext.Add(sdrfirst.GetString(0));
            }
            StaffInfo_SearchStaffFirstNameTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            StaffInfo_SearchStaffFirstNameTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            StaffInfo_SearchStaffFirstNameTxtBox.AutoCompleteCustomSource = autotext;
            con.Close();
        }

        private void StaffInfo_ResetBtn_Click(object sender, EventArgs e)
        {
            StaffInfo_SearchStaffFirstNameTxtBox.Text = "";
            StaffInfo_SearchStaffLastNameTxtBox.Text = "";
            StaffInfo_IDNumberField.Text = "_________";
            StaffInfo_FirstNameField.Text = "_________";
            StaffInfo_LastNameField.Text = "_________";
            StaffInfo_SpecializationField.Text = "_________";
            StaffInfo_MedicalCredsField.Text = "_________";
            StaffInfo_UsernameField.Text = "_________";
            StaffInfo_PasswordField.Text = "_________";
            StaffInfo_GenderField.Text = "_________";
            StaffInfo_EmailField.Text = "_________";
        }
    }
}
