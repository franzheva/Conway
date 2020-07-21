using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Conway
{
    public partial class AddNewFunction : Form
    {
        private readonly Function funcForm;
        static string conString = ConfigurationManager.ConnectionStrings["Conway.Properties.Settings.CellularAutomataConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(conString); 
        public AddNewFunction(Function form)
        {
            InitializeComponent();
            funcForm = form;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (FunctionNameTB.Text == "" || FunctionTB.Text == "")
            {
                NameLabelWarning.Text = "*Function Name is required";
                FunctionLabelWarning.Text = "*Function is required";
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CA_Analytical_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = FunctionNameTB.Text;
                cmd.Parameters.Add("@Function", SqlDbType.VarChar).Value = FunctionTB.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                funcForm.ResetCBData();
                this.Close();
            }
        }
    }
}
