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
    public partial class RemoveRoom : UserControl
    {
        private RentRoomContext db = new();
        private List<int?> unfreerooms = new();
        public RemoveRoom()
        {
            InitializeComponent();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (cbRooms.Text != "")
            {
                foreach (Room room in db.Rooms.ToList())
                {
                    if (room.NumRoom == Convert.ToInt32(cbRooms.Text))
                    {
                        db.Rooms.Remove(room);
                        db.SaveChanges();
                    }
                }
                cbRooms.Text = "";
            }
        }

        private void RemoveRoom_Load(object sender, EventArgs e)
        {
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                unfreerooms.Add(dogovor.NumRoom);
            }
            foreach (Room room in db.Rooms.ToList())
            {
                if (!unfreerooms.Contains(room.NumRoom))
                {
                    cbRooms.Items.Add(room.NumRoom);
                }
            }
        }
    }
}
