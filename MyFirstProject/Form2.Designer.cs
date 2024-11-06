namespace MyFirstProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainUsernameLabel = new Label();
            logoutButton = new Button();
            friendPage = new TabPage();
            chatPage = new TabPage();
            messageTextBox = new TextBox();
            chatTextBox = new TextBox();
            sendButton = new Button();
            accountPage = new TabControl();
            myAccountPage = new TabPage();
            chatPage.SuspendLayout();
            accountPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainUsernameLabel
            // 
            mainUsernameLabel.AutoSize = true;
            mainUsernameLabel.Location = new Point(24, 9);
            mainUsernameLabel.Name = "mainUsernameLabel";
            mainUsernameLabel.Size = new Size(59, 15);
            mainUsernameLabel.TabIndex = 2;
            mainUsernameLabel.Text = "username";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(12, 392);
            logoutButton.Name = "logoutButton";
            logoutButton.RightToLeft = RightToLeft.No;
            logoutButton.Size = new Size(89, 46);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Se déconnecter";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // friendPage
            // 
            friendPage.Location = new Point(4, 24);
            friendPage.Name = "friendPage";
            friendPage.Padding = new Padding(3);
            friendPage.Size = new Size(679, 423);
            friendPage.TabIndex = 1;
            friendPage.Text = "Amis";
            friendPage.UseVisualStyleBackColor = true;
            // 
            // chatPage
            // 
            chatPage.Controls.Add(sendButton);
            chatPage.Controls.Add(chatTextBox);
            chatPage.Controls.Add(messageTextBox);
            chatPage.Location = new Point(4, 24);
            chatPage.Name = "chatPage";
            chatPage.Padding = new Padding(3);
            chatPage.Size = new Size(679, 423);
            chatPage.TabIndex = 0;
            chatPage.Text = "Chat";
            chatPage.UseVisualStyleBackColor = true;
            // 
            // messageTextBox
            // 
            messageTextBox.AcceptsReturn = true;
            messageTextBox.AcceptsTab = true;
            messageTextBox.Location = new Point(16, 372);
            messageTextBox.MaximumSize = new Size(546, 38);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(546, 23);
            messageTextBox.TabIndex = 0;
            // 
            // chatTextBox
            // 
            chatTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatTextBox.Location = new Point(16, 6);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.ReadOnly = true;
            chatTextBox.ScrollBars = ScrollBars.Vertical;
            chatTextBox.Size = new Size(641, 356);
            chatTextBox.TabIndex = 2;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(582, 372);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 1;
            sendButton.Text = "Envoyer";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // accountPage
            // 
            accountPage.Controls.Add(chatPage);
            accountPage.Controls.Add(friendPage);
            accountPage.Controls.Add(myAccountPage);
            accountPage.Location = new Point(115, 1);
            accountPage.Name = "accountPage";
            accountPage.SelectedIndex = 0;
            accountPage.Size = new Size(687, 451);
            accountPage.TabIndex = 1;
            // 
            // myAccountPage
            // 
            myAccountPage.Location = new Point(4, 24);
            myAccountPage.Name = "myAccountPage";
            myAccountPage.Padding = new Padding(3);
            myAccountPage.Size = new Size(679, 423);
            myAccountPage.TabIndex = 2;
            myAccountPage.Text = "Mon compte";
            myAccountPage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(mainUsernameLabel);
            Controls.Add(accountPage);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            chatPage.ResumeLayout(false);
            chatPage.PerformLayout();
            accountPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainUsernameLabel;
        private Button logoutButton;
        private TabPage friendPage;
        private TabPage chatPage;
        private Button sendButton;
        private TextBox chatTextBox;
        private TextBox messageTextBox;
        private TabControl accountPage;
        private TabPage myAccountPage;
    }
}