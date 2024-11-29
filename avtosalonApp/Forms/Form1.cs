using avtosalonApp;
using avtosalonApp.UserControls;

namespace avtosalon
{
    public partial class Form1 : Form
    {
        private List<Client> clients;
        private List<Employee> Employees;
        private AvtosalonDbContext db = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleEnter(bool cond)
        {
            lblEnterMain.Visible = cond;
            lblEnterLogin.Visible = cond;
            lblEnterPassword.Visible = cond;
            txtboxEnterLogin.Visible = cond;
            txtboxEnterPassword.Visible = cond;
            btnEnterEnter.Visible = cond;
        }
        private void VisibleMenu(bool cond)
        {
            btnMenuEnter.Visible = cond;
            btnMenuReg.Visible = cond;
            lblMenuMain.Visible = cond;
        }
        private void VisibleReg(bool cond)
        {
            lblReg_Login.Visible = cond;
            lblReg_Name.Visible = cond;
            lblReg_NumTel.Visible = cond;
            lblReg_Password.Visible = cond;
            lblReg_Surname.Visible = cond;
            btnReg_Reg.Visible = cond;
            txtboxReg_Login.Visible = cond;
            txtboxReg_Name.Visible = cond;
            txtboxReg_NumTel.Visible = cond;
            txtboxReg_Password.Visible = cond;
            txtboxReg_Surname.Visible = cond;
        }

        private void btnMenuEnter_Click(object sender, EventArgs e)
        {
            VisibleMenu(false);
            VisibleEnter(true);
        }

        private void btnEnterEnter_Click(object sender, EventArgs e)
        {
            if (txtboxEnterLogin.Text == "admin" && txtboxEnterPassword.Text == "admin")
            {
                this.Hide();
                ClientInterface clientInterface = new(db.Clients.ToList()[0]);
                EmplInterface EmplInterface = new(db.Employees.ToList()[0]);
                clientInterface.Show();
                EmplInterface.Show();
            }
            foreach (Client client in clients)
            {
                if (client.LoginClient == txtboxEnterLogin.Text &&
                    client.PasswordClient == txtboxEnterPassword.Text)
                {
                    this.Hide();
                    ClientInterface clientInterface = new(client);
                    clientInterface.Show();
                    return;
                }
            }
            foreach (Employee Empl in Employees)
            {
                if (Empl.LoginEmpl == txtboxEnterLogin.Text &&
                    Empl.PasswordEmpl == txtboxEnterPassword.Text)
                {
                    this.Hide();
                    EmplInterface EmplInterface = new(Empl);
                    EmplInterface.Show();
                    return;
                }
            }
            lblEnter_Error.Text = "Неверный логин или пароль";
        }

        private void btnMenuReg_Click(object sender, EventArgs e)
        {
            VisibleMenu(false);
            VisibleReg(true);
        }

        private void btnReg_Reg_Click(object sender, EventArgs e)
        {
            //Создаём нового арендатора
            Client client = new Client
            {
                LoginClient = txtboxReg_Login.Text,
                PasswordClient = txtboxReg_Password.Text,
                ClientsFullName = txtboxReg_Surname.Text,
                ClientCity = txtboxReg_Name.Text,
                ClientPhoneNumber = txtboxReg_NumTel.Text
            };

            //добавляем арендатора в базу данных и сохраняем изменения
            db.Clients.Add(client);
            db.SaveChanges();

            //скрываем текущее окно
            this.Hide();

            //создаём новое окно для арендатора и показываем его
            ClientInterface clientInterface = new ClientInterface(client);
            clientInterface.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleEnter(false);
            VisibleReg(false);
            clients = db.Clients.ToList();
            Employees = db.Employees.ToList();
        }
    }

}
