namespace MyFirstProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            checkBox1 = new CheckBox();
            logPseudoBox = new TextBox();
            logPasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pseudoBox = new TextBox();
            emailBox = new TextBox();
            passwordRegBox = new TextBox();
            verifyPasswordBox = new TextBox();
            registerButton = new Button();
            label9 = new Label();
            verifyPasswordErrorLabel = new Label();
            passwordErrorLabel = new Label();
            mailErrorLabel = new Label();
            pseudoErrorLabel = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(386, 227);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 23);
            loginButton.TabIndex = 0;
            loginButton.Text = "Se connecter";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(388, 202);
            checkBox1.MaximumSize = new Size(150, 400);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Rester connecté";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // logPseudoBox
            // 
            logPseudoBox.Location = new Point(378, 120);
            logPseudoBox.Name = "logPseudoBox";
            logPseudoBox.Size = new Size(131, 23);
            logPseudoBox.TabIndex = 2;
            // 
            // logPasswordBox
            // 
            logPasswordBox.Location = new Point(378, 173);
            logPasswordBox.Name = "logPasswordBox";
            logPasswordBox.PasswordChar = '*';
            logPasswordBox.Size = new Size(131, 23);
            logPasswordBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 102);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 4;
            label1.Text = "Pseudo ou adresse mail";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 155);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 61);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Se créer un compte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 102);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Pseudo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 61);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 8;
            label5.Text = "Se connecter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 162);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 9;
            label6.Text = "Adresse Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 220);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 10;
            label7.Text = "Mot de passe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(148, 281);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 11;
            label8.Text = "Vérifier le mot de passe";
            // 
            // pseudoBox
            // 
            pseudoBox.Location = new Point(148, 120);
            pseudoBox.Name = "pseudoBox";
            pseudoBox.Size = new Size(131, 23);
            pseudoBox.TabIndex = 12;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(148, 180);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(131, 23);
            emailBox.TabIndex = 13;
            emailBox.TextChanged += EmailCheck;
            // 
            // passwordRegBox
            // 
            passwordRegBox.Location = new Point(148, 239);
            passwordRegBox.Name = "passwordRegBox";
            passwordRegBox.Size = new Size(131, 23);
            passwordRegBox.TabIndex = 14;
            passwordRegBox.TextChanged += PasswordCheck;
            // 
            // verifyPasswordBox
            // 
            verifyPasswordBox.Location = new Point(148, 302);
            verifyPasswordBox.Name = "verifyPasswordBox";
            verifyPasswordBox.Size = new Size(131, 23);
            verifyPasswordBox.TabIndex = 15;
            verifyPasswordBox.TextChanged += PasswordCheck;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(167, 353);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(93, 23);
            registerButton.TabIndex = 16;
            registerButton.Text = "S'inscrire";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 83);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // verifyPasswordErrorLabel
            // 
            verifyPasswordErrorLabel.AutoSize = true;
            verifyPasswordErrorLabel.ForeColor = Color.Red;
            verifyPasswordErrorLabel.Location = new Point(148, 330);
            verifyPasswordErrorLabel.Name = "verifyPasswordErrorLabel";
            verifyPasswordErrorLabel.Size = new Size(0, 15);
            verifyPasswordErrorLabel.TabIndex = 18;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(148, 265);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(0, 15);
            passwordErrorLabel.TabIndex = 19;
            // 
            // mailErrorLabel
            // 
            mailErrorLabel.AutoSize = true;
            mailErrorLabel.Location = new Point(148, 205);
            mailErrorLabel.Name = "mailErrorLabel";
            mailErrorLabel.Size = new Size(0, 15);
            mailErrorLabel.TabIndex = 20;
            // 
            // pseudoErrorLabel
            // 
            pseudoErrorLabel.AutoSize = true;
            pseudoErrorLabel.Location = new Point(148, 146);
            pseudoErrorLabel.Name = "pseudoErrorLabel";
            pseudoErrorLabel.Size = new Size(0, 15);
            pseudoErrorLabel.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 407);
            Controls.Add(pseudoErrorLabel);
            Controls.Add(mailErrorLabel);
            Controls.Add(passwordErrorLabel);
            Controls.Add(verifyPasswordErrorLabel);
            Controls.Add(label9);
            Controls.Add(registerButton);
            Controls.Add(verifyPasswordBox);
            Controls.Add(passwordRegBox);
            Controls.Add(emailBox);
            Controls.Add(pseudoBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logPasswordBox);
            Controls.Add(logPseudoBox);
            Controls.Add(checkBox1);
            Controls.Add(loginButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private CheckBox checkBox1;
        private TextBox logPseudoBox;
        private TextBox logPasswordBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox pseudoBox;
        private TextBox emailBox;
        private TextBox passwordRegBox;
        private TextBox verifyPasswordBox;
        private Button registerButton;
        private Label label9;
        private Label verifyPasswordErrorLabel;
        private Label passwordErrorLabel;
        private Label mailErrorLabel;
        private Label pseudoErrorLabel;
    }
}
