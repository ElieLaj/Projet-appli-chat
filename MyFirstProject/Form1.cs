using System;
using MyFirstProject.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static MyFirstProject.Tools.AccountManager;
using static MyFirstProject.Tools.Validators;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public static string username = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsLoginValid(logPseudoBox.Text, logPasswordBox.Text))
            {
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.username = logPseudoBox.Text;
                    Properties.Settings.Default.password = logPasswordBox.Text;  
                    Properties.Settings.Default.Save();
                }
                username = logPseudoBox.Text;
                MessageBox.Show("Bienvenue " + username);
                Form2 mainApp = new Form2(username);
                this.Hide();
                mainApp.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Il n'y a aucun compte avec cette combinaison de pseudo / mail et mot de passe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var errors = IsRegistrationValid(pseudoBox.Text, emailBox.Text, passwordRegBox.Text, verifyPasswordBox.Text);
            if (errors.Count == 0)
            {
                MessageBox.Show("Enregistrement réussi");
                CreateAccount(pseudoBox.Text, emailBox.Text, passwordRegBox.Text);
            }
            else
            {
                pseudoErrorLabel.Text = "";
                mailErrorLabel.Text = "";
                passwordErrorLabel.Text = "";

                foreach (var error in errors)
                {
                    if (error.Contains("pseudo"))
                    {
                        pseudoErrorLabel.Text = error;
                        pseudoErrorLabel.ForeColor = Color.Red;
                    }
                    else if (error.Contains("email"))
                    {
                        mailErrorLabel.Text = error;
                        mailErrorLabel.ForeColor = Color.Red;
                    }
                    else if (error.Contains("mot de passe"))
                    {
                        passwordErrorLabel.Text = error;
                        passwordErrorLabel.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void PasswordCheck(object sender, EventArgs e)
        {
            if (!IsPasswordSame(passwordRegBox.Text, verifyPasswordBox.Text))
            {
                verifyPasswordErrorLabel.Text = "Les deux mots de passes ne correspondent pas";
                verifyPasswordErrorLabel.ForeColor = Color.Red;
                passwordErrorLabel.Text = "Les deux mots de passes ne correspondent pas";
                passwordErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                verifyPasswordErrorLabel.Text = "";
                passwordErrorLabel.Text = "";
            }
        }

        private void EmailCheck(object sender, EventArgs e)
        {
            if (!IsEmailValid(emailBox.Text))
            {
                mailErrorLabel.Text = "L'email n'est pas valide";
                mailErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                mailErrorLabel.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(IsLoginValid(Properties.Settings.Default.username, Properties.Settings.Default.password))
            {
                username = Properties.Settings.Default.username;
                MessageBox.Show("Bienvenue " + username);
                Form2 mainApp = new Form2(username);
                this.Hide();
                mainApp.ShowDialog();
                this.Close();
            }
        }
    }
}
