using System.Windows.Forms;

namespace UP_Demo
{
    partial class GostForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBoxLogo = new PictureBox();
            buttonAutorize = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            labelSort = new Label();
            labelFiltr = new Label();
            comboBoxFiltr = new ComboBox();
            comboBoxSort = new ComboBox();
            ProductDataGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            ProductPhoto = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(buttonAutorize);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(labelSearch);
            panel1.Controls.Add(labelSort);
            panel1.Controls.Add(labelFiltr);
            panel1.Controls.Add(comboBoxFiltr);
            panel1.Controls.Add(comboBoxSort);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(310, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(162, 127);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonAutorize
            // 
            buttonAutorize.BackColor = Color.FromArgb(118, 227, 131);
            buttonAutorize.FlatStyle = FlatStyle.Popup;
            buttonAutorize.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAutorize.ImageAlign = ContentAlignment.TopCenter;
            buttonAutorize.Location = new Point(12, 94);
            buttonAutorize.Name = "buttonAutorize";
            buttonAutorize.Size = new Size(292, 26);
            buttonAutorize.TabIndex = 7;
            buttonAutorize.Text = "Авторизоваться";
            buttonAutorize.TextAlign = ContentAlignment.TopCenter;
            buttonAutorize.UseVisualStyleBackColor = false;
            buttonAutorize.Click += buttonAutorize_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(73, 140, 81);
            textBoxSearch.Location = new Point(12, 39);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(292, 26);
            textBoxSearch.TabIndex = 6;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.FromArgb(73, 140, 81);
            labelSearch.Location = new Point(12, 19);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(87, 17);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Поиск товара";
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSort.ForeColor = Color.FromArgb(73, 140, 81);
            labelSort.Location = new Point(623, 74);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(143, 17);
            labelSort.TabIndex = 4;
            labelSort.Text = "Отсортировать по цене";
            // 
            // labelFiltr
            // 
            labelFiltr.AutoSize = true;
            labelFiltr.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiltr.ForeColor = Color.FromArgb(73, 140, 81);
            labelFiltr.Location = new Point(547, 19);
            labelFiltr.Name = "labelFiltr";
            labelFiltr.Size = new Size(219, 17);
            labelFiltr.TabIndex = 3;
            labelFiltr.Text = "Отфильтровать по производителям";
            // 
            // comboBoxFiltr
            // 
            comboBoxFiltr.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFiltr.ForeColor = Color.FromArgb(73, 140, 81);
            comboBoxFiltr.FormattingEnabled = true;
            comboBoxFiltr.Items.AddRange(new object[] { "Triol", "trixie", "Cat Chow", "Fancy Pets", "TitBit", "Pro Plan", "LIKER", "True Touch", "ZooM", "Nobby", "Chappy", "Dog Chow", "Dreames" });
            comboBoxFiltr.Location = new Point(478, 39);
            comboBoxFiltr.Name = "comboBoxFiltr";
            comboBoxFiltr.Size = new Size(288, 26);
            comboBoxFiltr.TabIndex = 2;
            // 
            // comboBoxSort
            // 
            comboBoxSort.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSort.ForeColor = Color.FromArgb(73, 140, 81);
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "0 - 100", "100 - 500", "500 - 1000", "1000 - ∞", "Все" });
            comboBoxSort.Location = new Point(478, 94);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(288, 26);
            comboBoxSort.TabIndex = 1;
            // 
            // ProductDataGV
            // 
            ProductDataGV.AllowUserToAddRows = false;
            ProductDataGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = SystemColors.HighlightText;
            ProductDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductDataGV.BackgroundColor = Color.White;
            ProductDataGV.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(73, 140, 81);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ProductDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, ProductPhoto, Column6, Column7, Column8, Column9 });
            ProductDataGV.GridColor = Color.Silver;
            ProductDataGV.Location = new Point(12, 156);
            ProductDataGV.Name = "ProductDataGV";
            ProductDataGV.ReadOnly = true;
            ProductDataGV.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(73, 140, 81);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ProductDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            ProductDataGV.RowHeadersWidth = 50;
            ProductDataGV.RowTemplate.Height = 50;
            ProductDataGV.Size = new Size(754, 390);
            ProductDataGV.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductArticleNumber";
            Column1.HeaderText = "Артикул";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 76;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "Название";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 82;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductDescription";
            Column3.HeaderText = "Описание";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 86;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductCategory";
            Column4.HeaderText = "Категория";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 87;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Photo";
            Column5.HeaderText = "Фото";
            Column5.Image = Properties.Resources.picture;
            Column5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 39;
            // 
            // ProductPhoto
            // 
            ProductPhoto.DataPropertyName = "ProductPhoto";
            ProductPhoto.HeaderText = "ProductPhoto";
            ProductPhoto.Name = "ProductPhoto";
            ProductPhoto.ReadOnly = true;
            ProductPhoto.Visible = false;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ProductManufacturer";
            Column6.HeaderText = "Производитель";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 117;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ProductCost";
            Column7.HeaderText = "Цена";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 59;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "ProductDiscountAmount";
            Column8.HeaderText = "Скидка";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 69;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "ProductQuantityInStock";
            Column9.HeaderText = "Кол-во";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 70;
            // 
            // GostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(777, 561);
            Controls.Add(ProductDataGV);
            Controls.Add(panel1);
            Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "GostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО «Столовые приборы»";
            Load += GostForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxFiltr;
        private ComboBox comboBoxSort;
        private Label labelSort;
        private Label labelFiltr;
        private Button buttonAutorize;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private DataGridView ProductDataGV;
        private PictureBox pictureBoxLogo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewTextBoxColumn ProductPhoto;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}