namespace UP_Demo.Forms
{
    partial class Capcha
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
            pictureBoxCaptha = new PictureBox();
            labelCaptha = new Label();
            textBoxCaptha = new TextBox();
            buttonAutorize = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptha).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCaptha
            // 
            pictureBoxCaptha.Location = new Point(12, 12);
            pictureBoxCaptha.Name = "pictureBoxCaptha";
            pictureBoxCaptha.Size = new Size(254, 171);
            pictureBoxCaptha.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCaptha.TabIndex = 21;
            pictureBoxCaptha.TabStop = false;
            // 
            // labelCaptha
            // 
            labelCaptha.AutoSize = true;
            labelCaptha.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaptha.ForeColor = Color.FromArgb(73, 140, 81);
            labelCaptha.Location = new Point(80, 243);
            labelCaptha.Name = "labelCaptha";
            labelCaptha.Size = new Size(107, 23);
            labelCaptha.TabIndex = 24;
            labelCaptha.Text = "Введите код:";
            // 
            // textBoxCaptha
            // 
            textBoxCaptha.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCaptha.ForeColor = Color.FromArgb(73, 140, 81);
            textBoxCaptha.Location = new Point(25, 269);
            textBoxCaptha.Name = "textBoxCaptha";
            textBoxCaptha.Size = new Size(215, 30);
            textBoxCaptha.TabIndex = 23;
            // 
            // buttonAutorize
            // 
            buttonAutorize.BackColor = Color.White;
            buttonAutorize.FlatAppearance.BorderColor = Color.FromArgb(118, 227, 131);
            buttonAutorize.FlatStyle = FlatStyle.Popup;
            buttonAutorize.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAutorize.ForeColor = Color.FromArgb(73, 140, 81);
            buttonAutorize.ImageAlign = ContentAlignment.TopCenter;
            buttonAutorize.Location = new Point(25, 318);
            buttonAutorize.Name = "buttonAutorize";
            buttonAutorize.Size = new Size(215, 30);
            buttonAutorize.TabIndex = 25;
            buttonAutorize.Text = "Повторить";
            buttonAutorize.TextAlign = ContentAlignment.TopCenter;
            buttonAutorize.UseVisualStyleBackColor = false;
            buttonAutorize.Click += buttonAutorize_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.White;
            buttonRefresh.FlatAppearance.BorderColor = Color.FromArgb(118, 227, 131);
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.FromArgb(73, 140, 81);
            buttonRefresh.ImageAlign = ContentAlignment.TopCenter;
            buttonRefresh.Location = new Point(25, 189);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(215, 30);
            buttonRefresh.TabIndex = 26;
            buttonRefresh.Text = "Обновить код";
            buttonRefresh.TextAlign = ContentAlignment.TopCenter;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Capcha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(275, 360);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonAutorize);
            Controls.Add(labelCaptha);
            Controls.Add(textBoxCaptha);
            Controls.Add(pictureBoxCaptha);
            Name = "Capcha";
            Text = "Подтверждение";
            Load += Capcha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCaptha;
        private Label labelCaptha;
        private TextBox textBoxCaptha;
        private Button buttonAutorize;
        private Button buttonRefresh;
    }
}