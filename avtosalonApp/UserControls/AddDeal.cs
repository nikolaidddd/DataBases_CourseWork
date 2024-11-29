using avtosalonApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtosalon
{
    public partial class AddDeal : UserControl
    {
        AvtosalonDbContext db = new();
        Employee employee;
        private List<int?> unfreerooms = new();
        public AddDeal(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }
        private void AddDeal_Load(object sender, EventArgs e)
        {
            foreach (Deal deal in db.Deals.ToList())
            {
                unfreerooms.Add(deal.DealidCar);
            }
            foreach (Car car in db.Cars.ToList())
            {
                if (!unfreerooms.Contains(car.CarId))
                {
                    cbNumRoom.Items.Add(car.CarId);
                }
            }
            foreach (Client client in db.Clients.ToList())
            {
                cbClient.Items.Add(client.LoginClient);
            }
        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            if (cbClient.Text != "" && cbNumRoom.Text != "")
            {
                try
                {
                    Deal deal = new Deal
                    {
                        DealidCar = Convert.ToInt32(cbNumRoom.Text),
                        LoginClient = cbClient.Text,
                        LoginEmpl = employee.LoginEmpl,
                        PaymentDate = Convert.ToDateTime(textBox1.Text),
                        PaymentStatus = comboBox1.Text,
                        PaymentMethod = comboBox2.Text,

                    };
                    db.Deals.Add(deal);
                    db.SaveChanges();

                    cbNumRoom.Text = "";
                    cbClient.Text = "";
                    tbDateStart.Text = "";
                    tbDateEnd.Text = "";
                }
                catch
                {

                }
            }
        }
    }
}
