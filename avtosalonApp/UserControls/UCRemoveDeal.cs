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
    public partial class UCRemoveDogovor : UserControl
    {
        private RentRoomContext db = new();
        public UCRemoveDogovor()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbDogovors.Text != "")
            {
                foreach (Dogovor dogovor in db.Dogovors.ToList())
                {
                    if (dogovor.DogovorId == Convert.ToInt32(cbDogovors.Text))
                    {
                        db.Dogovors.Remove(dogovor);
                        db.SaveChanges();
                    }
                }
            }
            cbDogovors.Text = "";
        }

        private void UCRemoveDogovor_Load(object sender, EventArgs e)
        {
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                cbDogovors.Items.Add(dogovor.DogovorId);
            }
        }
    }
}
