using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avtosalonApp.UserControls;



namespace avtosalonApp
{
    public partial class EmplInterface : Form
    {
        private UCSearchCar ucSearchRoom;
        private UCKatalog ucKatalog;
        private UCMyDogovors ucMyDogovors;
        private Arendodatel currArendodatel;
        private UCAddClient ucAddClient;
        private AddDogovor ucAddDogovor;
        private UCAllClients ucAllClients;
        private UCAddRoom ucAddRoom;
        private RemoveRoom ucRemoveRoom;
        private UCRemoveClient ucRemoveClient;
        private UCRemoveDogovor ucRemoveDogovor;
        public EmplInterface(Employee employee)
        {
            InitializeComponent();
            currArendodatel = employee;
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchRoom = new();
            ucSearchRoom.Location = new Point(200, 75);
            this.Controls.Add(ucSearchRoom);
            ucSearchRoom.Show();
        }
        private void ArendodatelInterface_Load(object sender, EventArgs e)
        {
            ucSearchRoom = new();
            ucSearchRoom.Location = new Point(200, 75);
            this.Controls.Add(ucSearchRoom);

            ucKatalog = new();
            ucKatalog.Location = new Point(200, 75);
            this.Controls.Add(ucKatalog);

            ucMyDogovors = new(currArendodatel.LoginArendodatel);
            ucMyDogovors.Location = new Point(200, 75);
            this.Controls.Add(ucMyDogovors);

            ucAddClient = new();
            ucAddClient.Location = new Point(200, 75);
            this.Controls.Add(ucAddClient);

            ucAddDogovor = new(currArendodatel);
            ucAddDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucAddDogovor);

            ucAllClients = new(currArendodatel);
            ucAllClients.Location = new Point(200, 75);
            this.Controls.Add(ucAllClients);

            ucAddRoom = new();
            ucAddRoom.Location = new Point(200, 75);
            this.Controls.Add(ucAddRoom);

            ucRemoveRoom = new();
            ucRemoveRoom.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveRoom);

            ucRemoveClient = new();
            ucRemoveClient.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveClient);

            ucRemoveDogovor = new();
            ucRemoveDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveDogovor);
            HideAll();
        }
        private void HideAll()
        {
            //ucMyKabinet.Hide();
            ucRemoveRoom.Hide();
            ucMyDogovors.Hide();
            ucSearchRoom.Hide();
            ucKatalog.Hide();
            ucAddClient.Hide();
            ucAddDogovor.Hide();
            ucAllClients.Hide();
            ucAddRoom.Hide();
            ucRemoveClient.Hide();
            ucRemoveDogovor.Hide();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            HideAll();
            ucKatalog = new();
            ucKatalog.Location = new Point(200, 75);
            this.Controls.Add(ucKatalog);
            ucKatalog.Show();

        }

        private void btnMyDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucMyDogovors = new(currArendodatel.LoginArendodatel);
            ucMyDogovors.Location = new Point(200, 75);
            this.Controls.Add(ucMyDogovors);
            ucMyDogovors.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddClient = new();
            ucAddClient.Location = new Point(200, 75);
            this.Controls.Add(ucAddClient);
            ucAddClient.Show();
        }

        private void btnAddDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddDogovor = new(currArendodatel);
            ucAddDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucAddDogovor);
            ucAddDogovor.Show();
        }

        private void btnAllClients_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAllClients = new(currArendodatel);
            ucAllClients.Location = new Point(200, 75);
            this.Controls.Add(ucAllClients);
            ucAllClients.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddRoom = new();
            ucAddRoom.Location = new Point(200, 75);
            this.Controls.Add(ucAddRoom);
            ucAddRoom.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveRoom = new();
            ucRemoveRoom.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveRoom);
            ucRemoveRoom.Show();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveClient = new();
            ucRemoveClient.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveClient);
            ucRemoveClient.Show();
        }

        private void btnRemoveDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveDogovor = new();
            ucRemoveDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveDogovor);
            ucRemoveDogovor.Show();
        }
    }
}
