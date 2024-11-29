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
    public partial class UCAllArendators : UserControl
    {
        private Arendodatel arendodatel;
        List<Dogovor> arendators = new();
        public RentRoomContext db = new();
        public UCAllArendators(Arendodatel arendodatel)
        {
            this.arendodatel = arendodatel;
            InitializeComponent();
        }

        private void UCAllArendators_Load(object sender, EventArgs e)
        {
            int j = 0;
            dgvArendators.ColumnCount = 5;
            dgvArendators.Columns[0].Name = "Логин";
            dgvArendators.Columns[1].Name = "Пароль";
            dgvArendators.Columns[2].Name = "Фамилия";
            dgvArendators.Columns[3].Name = "Имя";
            dgvArendators.Columns[4].Name = "Телефон";
            foreach (Arendator arendator in db.Arendators.ToList())
            {
                dgvArendators.Rows.Add();
                dgvArendators.Rows[j].Cells[0].Value = arendator.LoginArendator;
                dgvArendators.Rows[j].Cells[1].Value = arendator.PasswordArendator;
                dgvArendators.Rows[j].Cells[2].Value = arendator.SurNameArendator;
                dgvArendators.Rows[j].Cells[3].Value = arendator.NameArendator;
                dgvArendators.Rows[j].Cells[4].Value = arendator.MobTelArendator;
                j++;
            }
            dgvArendators.RowHeadersVisible = false;
        }
    }
}
