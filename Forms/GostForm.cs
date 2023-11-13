using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using UP_Demo.Classes;
using UP_Demo.Forms;

namespace UP_Demo
{
    public partial class GostForm : Form
    {
        DataBase data = new DataBase();
        public GostForm()
        {
            data.GetConnection();
            InitializeComponent();
        }

        private void GostForm_Load(object sender, EventArgs e)
        {
            //data.OpenConnection();  // открываем соединение с бд
            //// создаем команду на запрос вывода всех данных из таблицы Product
            //SqlCommand command = new SqlCommand("select * from Product", data.GetConnection());
            //// определяем адаптер, он необходим для отправки запроса в бд
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //// создаем таблицу, куда будут передаваться данные из бд
            //DataTable dataTable = new DataTable();
            //// добавляем/обнавляем строки в адаптере
            //dataAdapter.Fill(dataTable);
            //// вызываем метод для отображения картинок
            //AddPhoto(dataTable);
            //// передаем готовую таблицу для отображения в DGV
            //ProductDataGV.DataSource = dataTable;
            //data.CloseConnection(); // закрываем соединение

            // Позволяет переносить текст в ячейке на новую строку
            ProductDataGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // Объявляем таблицу данных в которой будет формироваться таблица из БД
            // И передаем в нее запрос
            DataTable dataTable = data.SqlSelect("select * from Product");
            // Также для этой таблицы выполняем метод отображения фото
            AddPhoto(dataTable);
            // Передаем сформированную таблицу в элемент DataGridView
            ProductDataGV.DataSource = dataTable;   
            // Закрываем соединение
            data.CloseConnection();

        }

        /// <summary>
        /// метод для преобразования строкового значения картинки из БД в изображения
        /// </summary>
        /// <param name="dt"></param>
        private void AddPhoto(DataTable dt)
        {
            dt.Columns.Add("Photo", Type.GetType("System.Byte[]"));
            foreach (DataRow row in dt.Rows)
            {
                row["Photo"] = File.ReadAllBytes(row["ProductPhoto"].ToString());
            }
        }

        private void buttonAutorize_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm form = new AutorizationForm();
            form.Show();
        }
    }
}