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
            //data.OpenConnection();  // ��������� ���������� � ��
            //// ������� ������� �� ������ ������ ���� ������ �� ������� Product
            //SqlCommand command = new SqlCommand("select * from Product", data.GetConnection());
            //// ���������� �������, �� ��������� ��� �������� ������� � ��
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //// ������� �������, ���� ����� ������������ ������ �� ��
            //DataTable dataTable = new DataTable();
            //// ���������/��������� ������ � ��������
            //dataAdapter.Fill(dataTable);
            //// �������� ����� ��� ����������� ��������
            //AddPhoto(dataTable);
            //// �������� ������� ������� ��� ����������� � DGV
            //ProductDataGV.DataSource = dataTable;
            //data.CloseConnection(); // ��������� ����������

            // ��������� ���������� ����� � ������ �� ����� ������
            ProductDataGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // ��������� ������� ������ � ������� ����� ������������� ������� �� ��
            // � �������� � ��� ������
            DataTable dataTable = data.SqlSelect("select * from Product");
            // ����� ��� ���� ������� ��������� ����� ����������� ����
            AddPhoto(dataTable);
            // �������� �������������� ������� � ������� DataGridView
            ProductDataGV.DataSource = dataTable;   
            // ��������� ����������
            data.CloseConnection();

        }

        /// <summary>
        /// ����� ��� �������������� ���������� �������� �������� �� �� � �����������
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