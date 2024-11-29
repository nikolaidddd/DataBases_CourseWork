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
    public partial class UCSearchRoom : UserControl
    {
        private RentRoomContext db = new();
        private List<UCRoom> roomList = new();
        private List<UCRoom> _roomList = new();
        private List<int?> unfreerooms = new();
        private int currRoom = 0;
        public UCSearchRoom()
        {
            InitializeComponent();
        }
        private void UCSearchRoom_Load(object sender, EventArgs e)
        {
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                unfreerooms.Add(dogovor.NumRoom);
            }
            foreach (Room room in db.Rooms.ToList())
            {
                if (!unfreerooms.Contains(room.NumRoom))
                {
                    UCRoom ucRoom = new(room);
                    ucRoom.Location = new Point(91, 150);
                    ucRoom.Hide();
                    Controls.Add(ucRoom);
                    roomList.Add(ucRoom);
                    _roomList.Add(ucRoom);
                }
            }
        }
        private void HideAll()
        {
            foreach (UCRoom ucRoom in roomList)
            {
                ucRoom.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HideAll();
            _roomList.Clear();
            foreach (UCRoom ucRoom in roomList)
            {
                _roomList.Add(ucRoom);
            }
            currRoom = 0;
            foreach (UCRoom ucRoom in roomList)
            {
                if (txtboxSpace.Text != "" && ucRoom.room.GeneralSpace < Convert.ToInt32(txtboxSpace.Text))
                {
                    _roomList.Remove(ucRoom);
                    continue;
                }
                if (txtboxFloor.Text != "" && ucRoom.room.NumFloor < Convert.ToInt32(txtboxFloor.Text))
                {
                    _roomList.Remove(ucRoom);
                    continue;
                }
                if (txtboxCost.Text != "" && ucRoom.room.MonthPrice > Convert.ToDecimal(txtboxCost.Text))
                {
                    _roomList.Remove(ucRoom);
                    continue;
                }
                if (cbCondition.Checked && ucRoom.room.AirCondition != "есть")
                {
                    _roomList.Remove(ucRoom);
                    continue;
                }
                if (cbFurniture.Checked && ucRoom.room.Furniture != "есть")
                {
                    _roomList.Remove(ucRoom);
                    continue;
                }
            }
            if (_roomList.Count == 0)
            {
                return;
            }
            _roomList[currRoom].Show();
            currRoom++;
            if (_roomList.Count > 1)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
            btnPrev.Enabled = false;
            txtboxSpace.Text = "";
            txtboxFloor.Text = "";
            txtboxCost.Text = "";
            cbCondition.Text = "";
            cbFurniture.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HideAll();
            _roomList[currRoom].Show();
            currRoom++;
            if (currRoom == _roomList.Count)
            {
                btnNext.Enabled = false;
            }
            btnPrev.Enabled = true;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            HideAll();
            currRoom -= 2;
            _roomList[currRoom].Show();
            currRoom++;
            if (currRoom == 1)
            {
                btnPrev.Enabled = false;
            }
            btnNext.Enabled = true;
        }

        private void txtboxSpace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
