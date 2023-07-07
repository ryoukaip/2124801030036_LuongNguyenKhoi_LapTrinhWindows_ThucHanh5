using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace _2124801030036_LuongNguyenKhoi_LapTrinhWindows_ThucHanh5
{
    internal class SQLiteHandler
    {
        public static SQLiteConnection openConnection()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=data.db;Version=3;");
            // try catch open connection
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
        // close connection
        public static void closeConnection(SQLiteConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void executeCommand(SQLiteConnection conn, string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static DataTable toDataTable(SQLiteConnection conn, string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public static List<string> OneColumnToList(SQLiteConnection conn, string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }
    }
}
