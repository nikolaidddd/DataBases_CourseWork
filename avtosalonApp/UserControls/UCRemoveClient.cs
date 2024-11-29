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
    public partial class UCRemoveArendator : UserControl
    {
        private RentRoomContext db = new();
        private List<string?> loginArendators = new();
        public UCRemoveArendator()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbArendator.Text != "")
            {
                foreach (Arendator arendator in db.Arendators.ToList())
                {
                    if (arendator.LoginArendator == cbArendator.Text)
                    {
                        db.Arendators.Remove(arendator);
                        db.SaveChanges();
                    }
                }
            }
            cbArendator.Text = "";
        }

        private void UCRemoveArendator_Load(object sender, EventArgs e)
        {
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                loginArendators.Add(dogovor.LoginArendator);
            }
            foreach (Arendator arendator in db.Arendators.ToList())
            {
                if (!loginArendators.Contains(arendator.LoginArendator))
                {
                    cbArendator.Items.Add(arendator.LoginArendator);
                }
            }
        }
    }
}
