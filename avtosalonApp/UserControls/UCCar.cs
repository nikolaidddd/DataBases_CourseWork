using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VPIProject
{
    public partial class UCRoom : UserControl
    {
        public Room room { get; set; }
        public UCRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
        }

        private void UCRoom_Load(object sender, EventArgs e)
        {
            lblNumRoom.Text += room.NumRoom;
            lblSpace.Text += room.GeneralSpace;
            lblFurniture.Text += room.Furniture;
            lblFloor.Text += room.NumFloor;
            lblCost.Text += room.MonthPrice;
            lblCondition.Text += room.AirCondition;
        }
    }
}
