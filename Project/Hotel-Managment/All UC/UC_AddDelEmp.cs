using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment.All_UC
{
    

    public partial class UC_AddDelEmp : UserControl
    {
        DataLayer dl = new DataLayer("DESKTOP-BJGC910\\SQLEXPRESS", "Hotel2");
        DataTable dtemp;
        public UC_AddDelEmp()
        {
            InitializeComponent();
        }

        public void UC_AddDelEmp_Load(object sender, EventArgs e)
        {
            dtemp = dl.GetData("select IdEmp, nom, prenom, username from Employees");
            dgemp.DataSource = dtemp;
            changeEmp.DataSource = dtemp;
            changeEmp.DisplayMember = "Username";
            changeEmp.ValueMember = "IdEmp";
        }

        private void btndeleteemp_Click(object sender, EventArgs e)
        {
            if (changeEmp.Text != "" && changepass.Text != "" && newu.Text != "")
            {
                string un = changeEmp.Text;
                string newuser = newu.Text;
                string Dp = changepass.Text;
                object[,] param = new object[2, 3];
                param[0, 0] = "@usern";
                param[1, 0] = un;
                param[0, 1] = "@pass";
                param[1, 1] = Dp ;
                param[0, 2] = "@nusern";
                param[1, 2] = newuser;

                int a = dl.ExecuteActionCommand_Procedure("Changeusername", param);
                if (a >= 1)
                {
                    UC_AddDelEmp_Load(sender, e);
                    MessageBox.Show("Username Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Wrong password !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               

            }
            else
            { 
                MessageBox.Show("Fill all fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnaddemp_Click(object sender, EventArgs e)
        {  
            if(Fname.Text!="" && Lname.Text!="" && usern.Text!="" && pass.Text!="")
            {   if(pass.Text.Length<7)
                {
                    MessageBox.Show("Password should be longer (7 charac at least)", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {   string f = Fname.Text;
                    string l = Lname.Text;
                    string un = usern.Text;
                    string p = pass.Text;

                    object[,] param = new object[2, 4];
                    param[0, 0] = "@empn";
                    param[1, 0] = f;
                    param[0, 1] = "@empfn";
                    param[1, 1] = l;
                    param[0, 2] = "@usern";
                    param[1, 2] = un;
                    param[0, 3] = "passw";
                    param[1, 3] = p;
                    int a = dl.ExecuteActionCommand_Procedure("addEmp", param);
                    if(a>=1)
                    {
                        UC_AddDelEmp_Load(sender, e);
                        MessageBox.Show("Employee Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Username already Exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
               
                
            }
            else
            {
                MessageBox.Show("Fill all fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void DelEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
