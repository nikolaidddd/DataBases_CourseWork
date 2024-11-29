using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VPIProject
{
    public partial class UCAddArendator : UserControl
    {
        RentRoomContext roomContext = new();
        public UCAddArendator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbPassword.Text != "" &&
                tbSurname.Text != "" && tbName.Text != "" && tbNomTel.Text != "")
            {
                //Создаём нового арендатора
                Arendator arendator = new Arendator
                {
                    LoginArendator = tbLogin.Text,
                    PasswordArendator = tbPassword.Text,
                    SurNameArendator = tbSurname.Text,
                    NameArendator = tbName.Text,
                    MobTelArendator = tbNomTel.Text
                };

                //добавляем арендатора в базу данных и сохраняем изменения
                roomContext.Arendators.Add(arendator);
                roomContext.SaveChanges();
                tbLogin.Text = "";
                tbPassword.Text = "";
                tbSurname.Text = "";
                tbName.Text = "";
                tbNomTel.Text = "";
            }
        }

        private void UCAddArendator_Load(object sender, EventArgs e)
        {

        }
    }
}
