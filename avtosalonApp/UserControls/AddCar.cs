using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPIProject
{
    public partial class UCAddRoom : UserControl
    {
        private RentRoomContext db = new();
        public UCAddRoom()
        {
            InitializeComponent();
        }

        private void UCAddRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room room = new();
            if (txtboxNumRoom.Text != "")
            {
                room.NumRoom = Convert.ToInt32(txtboxNumRoom.Text);
            }
            if (txtboxSpace.Text != "")
            {
                room.GeneralSpace = Convert.ToInt32(txtboxSpace.Text);
            }
            if (txtboxFloor.Text != "")
            {
                room.NumFloor = Convert.ToInt32(txtboxFloor.Text);
            }
            if (txtboxCost.Text != "")
            {
                room.MonthPrice = Convert.ToDecimal(txtboxCost.Text);
            }
            if (cbCondition.Checked)
            {
                room.AirCondition = "есть";
            }
            if (cbFurniture.Checked)
            {
                room.Furniture = "есть";
            }
            db.Rooms.Add(room);
            db.SaveChanges();
            txtboxNumRoom.Text = "";
            txtboxSpace.Text = "";
            txtboxFloor.Text = "";
            txtboxCost.Text = "";
            cbCondition.Checked = false;
            cbFurniture.Checked = false;
        }
    }
}
