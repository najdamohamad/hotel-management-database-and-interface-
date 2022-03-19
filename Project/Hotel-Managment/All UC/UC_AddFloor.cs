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
    public partial class UC_AddFloor : UserControl
    {
        DataLayer dl = new DataLayer("DESKTOP-BJGC910\\SQLEXPRESS", "Hotel2");
        DataTable dtfloor;
        public UC_AddFloor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgfloor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void UC_AddFloor_Load(object sender, EventArgs e)
        {
            dtfloor = dl.GetData("select * from Etages", "Etages");
            dgfloor.DataSource = dtfloor;
        }

        private void btnaddfloor_Click(object sender, EventArgs e)
        {
            if (floornbr.Text != "" && nbrofrooms.Text != "")
            {


                string fn = floornbr.Text;
                int nr = int.Parse(nbrofrooms.Text);

                object[,] param = new object[2, 2];
                param[0, 0] = "@fn";
                param[1, 0] = fn;
                param[0, 1] = "@maxroomnbr";
                param[1, 1] = nr;

                int resp = dl.ExecuteActionCommand_Procedure("addfloor", param);
                if (resp >=1)
                {
                    UC_AddFloor_Load(sender, e);
                    MessageBox.Show("Floor Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Number of Rooms should be > 0!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Fill all fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
