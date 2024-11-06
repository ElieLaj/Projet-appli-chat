using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form2 : Form
    {
        private string _username;
        private TcpClient _client;
        private StreamWriter _writer;
        private StreamReader _reader;
        private Thread _listenThread;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public Form2(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mainUsernameLabel.Text = _username;
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                // Connecte au serveur sur localhost:5000
                _client = new TcpClient("127.0.0.1", 5000);
                NetworkStream stream = _client.GetStream();
                _writer = new StreamWriter(stream) { AutoFlush = true };
                _reader = new StreamReader(stream);

                // Envoie un message de connexion avec le nom d'utilisateur
                _writer.WriteLine($"{_username} a rejoint le chat");

                // Démarre un thread pour écouter les messages du serveur
                _listenThread = new Thread(() => ListenForMessages(_cancellationTokenSource.Token));
                _listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter au serveur : " + ex.Message);
                DisconnectFromServer();
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
                Form1 logApp = new Form1();
                this.Hide();
                logApp.ShowDialog();
                this.Close();
            }
        }

        private void ListenForMessages(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    // Lit les messages du serveur
                    string message = _reader.ReadLine();
                    if (message != null)
                    {
                        // Met à jour l'interface avec les messages reçus
                        Invoke(new Action(() =>
                        {
                            chatTextBox.AppendText(message + Environment.NewLine);
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                if (!token.IsCancellationRequested)
                {
                    MessageBox.Show("Erreur lors de la réception des messages : " + ex.Message);
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // Envoie le message au serveur
            if (!string.IsNullOrEmpty(messageTextBox.Text))
            {
                string message = $"{_username}: {messageTextBox.Text}";
                _writer.WriteLine(message);
                messageTextBox.Clear();
                Invoke(new Action(() =>
                {
                    chatTextBox.AppendText(message + Environment.NewLine);
                }));
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Ferme la connexion et quitte le chat
            DisconnectFromServer();
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            Form1 logApp = new Form1();
            this.Hide();
            logApp.ShowDialog();
            this.Close();
        }

        private void DisconnectFromServer()
        {
            // Déconnecte le client proprement
            if (_client != null)
            {
                _writer.WriteLine($"{_username} a quitté le chat");
                _cancellationTokenSource.Cancel();
                _reader?.Close();
                _writer?.Close();
                _client?.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // S'assure de fermer la connexion lorsque le formulaire est fermé
            DisconnectFromServer();
        }
    }
}