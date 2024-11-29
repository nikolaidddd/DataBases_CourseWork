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
    public partial class UCMyKabinet : UserControl
    {
        private Arendator arendator;
        public UCMyKabinet(Arendator arendator)
        {
            InitializeComponent();
            this.arendator = arendator;
        }

        private void UCMyKabinet_Load(object sender, EventArgs e)
        {
            lblKabLogin.Text += arendator.LoginArendator;
            lblKabPassword.Text += arendator.PasswordArendator;
            lblKabSurname.Text += arendator.SurNameArendator;
            lblKabName.Text += arendator.NameArendator;
            lblKabNomTel.Text += arendator.MobTelArendator;
        }
    }
}
