using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UP_Demo.Classes
{
    public class DataBase
    {
        /// <summary>
        /// Объявление строки подключения с БД
        /// </summary>
        SqlConnection sqlConnection = new SqlConnection(@"Server=Anastasia-ПК;Database=Trade;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");

        /// <summary>
        /// Метод для открытия соединения с БД
        /// </summary>
        public void OpenConnection()
        {
            // если состояние строки закрыто, то открываем
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// Метод для закрытия соединения с БД, обратный методу выше
        /// </summary>
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Метод, возвращающий строку подключения
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        /// <summary>
        /// Метод для обработки запросов типа Select
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataTable SqlSelect(String s)
        {
            SqlCommand command = new SqlCommand(s); // создаем команду с запросом
            command.Connection = GetConnection();   // открываем соединение с БД
            SqlDataAdapter adapter = new SqlDataAdapter(command);   // адаптируем данные
            DataTable table = new DataTable();      // создаем таблицу
            adapter.Fill(table);    // через адаптер заполняем ее данными
            return table;           // возвращаем таблицу
        }

        /// <summary>
        /// Метод для обработки запросов типа Insert
        /// </summary>
        /// <param name="querystring"></param>
        /// <returns></returns>
        public SqlCommand SqlInsert(String querystring)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(querystring);
            command.Connection = GetConnection();
            command.ExecuteNonQuery();
            CloseConnection();
            return command;
        }

    }
}
