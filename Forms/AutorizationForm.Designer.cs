namespace UP_Demo.Forms
{
    partial class AutorizationForm
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
            buttonAutorize = new Button();
            labelPassword = new Label();
            labelLogin = new Label();
            textBoxPassword = new TextBox();
            pictureBoxLogo = new PictureBox();
            textBoxLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonAutorize
            // 
            buttonAutorize.BackColor = Color.White;
            buttonAutorize.FlatAppearance.BorderColor = Color.FromArgb(118, 227, 131);
            buttonAutorize.FlatStyle = FlatStyle.Popup;
            buttonAutorize.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAutorize.ForeColor = Color.FromArgb(73, 140, 81);
            buttonAutorize.ImageAlign = ContentAlignment.TopCenter;
            buttonAutorize.Location = new Point(94, 479);
            buttonAutorize.Name = "buttonAutorize";
            buttonAutorize.Size = new Size(205, 30);
            buttonAutorize.TabIndex = 19;
            buttonAutorize.Text = "Войти";
            buttonAutorize.TextAlign = ContentAlignment.TopCenter;
            buttonAutorize.UseVisualStyleBackColor = false;
            buttonAutorize.Click += buttonAutorize_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(73, 140, 81);
            labelPassword.Location = new Point(128, 216);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(135, 23);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Введите пароль:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.FromArgb(73, 140, 81);
            labelLogin.Location = new Point(128, 154);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(127, 23);
            labelLogin.TabIndex = 17;
            labelLogin.Text = "Введите E-mail:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.FromArgb(73, 140, 81);
            textBoxPassword.Location = new Point(12, 242);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(371, 30);
            textBoxPassword.TabIndex = 16;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(113, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(162, 127);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 15;
            pictureBoxLogo.TabStop = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.FromArgb(73, 140, 81);
            textBoxLogin.Location = new Point(12, 180);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(371, 30);
            textBoxLogin.TabIndex = 14;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 521);
            Controls.Add(buttonAutorize);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxLogin);
            Name = "AutorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО \"Столовые приборы\"";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAutorize;
        private Label labelPassword;
        private Label labelLogin;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxLogo;
        private TextBox textBoxLogin;
    }
}