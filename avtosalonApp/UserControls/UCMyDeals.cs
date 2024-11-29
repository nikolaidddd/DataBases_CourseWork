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
    public partial class UCMyDogovors : UserControl
    {
        string SearchLogin;
        List<Dogovor> dogovors = new();
        public RentRoomContext db = new();

        public UCMyDogovors(string Login)
        {
            InitializeComponent();
            SearchLogin = Login;
        }

        private void UCMyDogovors_Load(object sender, EventArgs e)
        {
            dgvDogovors.ColumnCount = 5;
            dgvDogovors.Columns[0].Name = "Номер комнаты";
            dgvDogovors.Columns[1].Name = "Дата начала";
            dgvDogovors.Columns[2].Name = "Дата окончания";
            dgvDogovors.Columns[3].Name = "Арендатор";
            dgvDogovors.Columns[4].Name = "Арендодатель";
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                if (SearchLogin == dogovor.LoginArendator || SearchLogin == dogovor.LoginArendodatel)
                {
                    dogovors.Add(dogovor);
                }
            }
            for (int i = 0; i < dogovors.Count; i++)
            {
                dgvDogovors.Rows.Add();
                dgvDogovors.Rows[i].Cells[0].Value = dogovors[i].NumRoom;
                dgvDogovors.Rows[i].Cells[1].Value = dogovors[i].DataStartDogovor;
                dgvDogovors.Rows[i].Cells[2].Value = dogovors[i].DataEndDogovor;
                dgvDogovors.Rows[i].Cells[3].Value = dogovors[i].LoginArendator;
                dgvDogovors.Rows[i].Cells[4].Value = dogovors[i].LoginArendodatel;
            }
            dgvDogovors.RowHeadersVisible = false;
        }
    }
}
