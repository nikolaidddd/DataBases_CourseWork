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
    public partial class UCKatalog : UserControl
    {
        private RentRoomContext db = new();
        private List<UCRoom> roomList = new();
        private int currRoom = 0;
        private List<int?> unfreerooms = new();
        public UCKatalog()
        {
            InitializeComponent();
        }

        private void UCKatalog_Load(object sender, EventArgs e)
        {
            int i = 30;
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                unfreerooms.Add(dogovor.NumRoom);
            }
            foreach (Room room in db.Rooms.ToList())
            {
                if (!unfreerooms.Contains(room.NumRoom))
                {
                    UCRoom ucRoom = new(room);
                    ucRoom.Location = new Point(75, i);
                    ucRoom.Hide();
                    Controls.Add(ucRoom);
                    roomList.Add(ucRoom);
                    i += 140;
                    if (i > 180)
                    {
                        i = 30;
                    }
                }
            }
            currRoom = 0;

            roomList[currRoom].Show();
            currRoom++;

            if (roomList.Count == currRoom)
            {
                return;
            }

            roomList[currRoom].Show();
            currRoom++;

            if (roomList.Count <= currRoom)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
            btnPrev.Enabled = false;
        }
        private void HideAll()
        {
            foreach (UCRoom room in roomList)
            {
                room.Hide();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            HideAll();
            if (currRoom % 2 == 1)
            {
                currRoom -= 3;
            }
            else
            {
                currRoom -= 4;
            }
            roomList[currRoom].Show();
            currRoom++;
            if (currRoom != 2)
            {
                roomList[currRoom].Show();
                currRoom++;
            }
            if (currRoom <= 2)
            {
                btnPrev.Enabled = false;
            }
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //скрыть последние два помещения
            roomList[currRoom - 1].Hide();
            roomList[currRoom - 2].Hide();

            //показать текущую
            roomList[currRoom].Show();
            currRoom++;
            if (roomList.Count != currRoom)
            {
                roomList[currRoom].Show();
                currRoom++;
            }
            if (roomList.Count <= currRoom)
            {
                btnNext.Enabled = false;
            }
            btnPrev.Enabled = true;

        }
    }
}
