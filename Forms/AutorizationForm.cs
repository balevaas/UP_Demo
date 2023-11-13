using System.Data;
using System.Windows.Forms;
using UP_Demo.Classes;

namespace UP_Demo.Forms
{
    public partial class AutorizationForm : Form
    {
        DataBase dataBase = new DataBase();
        private int loginAttempts;
        public AutorizationForm()
        {
            dataBase.GetConnection();
            InitializeComponent();
        }

        private void buttonAutorize_Click(object sender, EventArgs e)
        {
            string email = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Вы не ввели почту или пароль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dataBase.SqlSelect("select * from [dbo].[User] where UserLogin = '" + textBoxLogin.Text + "' and UserPassword = '" + textBoxPassword.Text + "'").Rows.Count > 0)
                {
                    DataTable dt = dataBase.SqlSelect($"select [UserRole] from [dbo].[User] where [UserLogin] = '" + email + "'");
                    int role = Convert.ToInt32(dt.Rows[0][0]);
                    if (role == 1)
                    {
                        MessageBox.Show("Administrator", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (role == 2)
                    {
                        MessageBox.Show("Manager", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (role == 3)
                    {
                        MessageBox.Show("Client", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Данные введены неккоректно", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginAttempts++;
                    if (loginAttempts == 3)
                    {
                        Capcha capcha = new Capcha();
                        capcha.Show();
                        this.Hide();
                        buttonAutorize.Enabled = false;
                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Interval = 250000;
                        timer.Tick += new EventHandler(Timer_Tick);
                        timer.Start();

                    }
                }

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            buttonAutorize.Enabled = true;
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            timer.Stop();
            timer.Dispose();
        }
    }
}
