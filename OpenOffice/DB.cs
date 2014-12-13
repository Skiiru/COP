using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;


namespace OpenOffice
{
    class DB
    {
        public string conString;

        public DB(string path)
        {
            try
            {
                if(!File.Exists(path))
                    SQLiteConnection.CreateFile(path);
                this.conString = @"Data Source=" + @path + ";Version=3;";
            }
            catch
            {
                this.conString = null;
            }
        }

        public delegate object Query(string query);
        public event Query ExecutingQuery;
        public event Query ExecutingNonQuery;

        public object GetTableNames()
        {
            try
            {
                string query = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1";
                DataTable table = ExecQuery(query) as DataTable;
                List<string> tbNames = new List<string>();
                // Return all table names in the ArrayList

                foreach (DataRow row in table.Rows)
                {
                    tbNames.Add(row.ItemArray[0].ToString());
                }
                return tbNames;
            }
            catch (Exception ex)
            {
                return "GetTableNames: "+ ex.Message;
            }
        }
        public object GetColumnNames(string tableName)
        {
            try
            {
                string query = "pragma table_info(" + tableName + ");";
                DataTable table = ExecQuery(query) as DataTable;
                List<string> tbNames = new List<string>();
                // Return all table names in the ArrayList

                foreach (DataRow row in table.Rows)
                {
                    tbNames.Add(row.ItemArray[1].ToString());
                }
                return tbNames;
            }
            catch (Exception ex)
            {
                return "GetTableNames: " + ex.Message;
            }
        }
        #region Обёртки
        public string CreateTable(string name,Dictionary<string,string> columns)
        {
            string query = "create table " + name + " (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,";
            try
            {
                int k = 0;
                foreach(KeyValuePair<string,string> kvp in columns)
                {
                    k++;
                    query += kvp.Key + ' ' + kvp.Value;
                    if(k!=columns.Values.Count)
                        query += ',';
                    else
                        query += ");";
                }
                return ExecNonQuery(query);
            }
            catch(Exception ex)
            {
                return ex.Message + "in query: " + query; ;
            }
        }
        public Object OpenTable(string Name)
        {
            try
            {
                string query = "SELECT * FROM " + Name + ";";
                object dt = ExecQuery(query);
                if (dt is DataTable)
                    return dt as DataTable;
                else
                    return dt;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Object OpenTable(string Name, string Condition)
        {
            try
            {
                string query = "SELECT * FROM " + Name + ' ' + "where " +Condition+ ";";
                object dt = ExecQuery(query);
                if (dt is DataTable)
                    return dt as DataTable;
                else
                    return dt;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(string tableName,int id, Dictionary<string,string> Columns)
        {
            try
            {
                int k = 0;
                string query = "Update " + tableName + " set ";
                foreach (KeyValuePair<string, string> kv in Columns)
                {
                    k++;
                    query += kv.Key + "=" +'\'' + kv.Value + '\'';
                    if (k != Columns.Count)
                        query += ", ";
                    else
                    {
                        query += " where id=" + id.ToString() + ';';
                    }
                }
                string res = ExecNonQuery(query);
                return res;
            }
            catch (Exception ex)
            {
                return "Update function error: " + ex.Message;
            }
        }
        public string Insert(string tableName, Dictionary<string,string> columns)
        {
            string col=string.Empty;
            string values=string.Empty;
            int k = 0;
            foreach(KeyValuePair<string,string> kv in columns)
            {
                k++;
                col+=kv.Key;
                values += '\''+ kv.Value + '\'';
                if(k<columns.Count)
                {
                    col += ", ";
                    values += ", ";
                }
            }
            string query = "INSERT INTO " + tableName + " ("+col+" ) values(" + values+ ");";
            return ExecNonQuery(query);
        }
        public string Delete(string tableName, int id)
        {
            string query = "delete from " + tableName + " where id=" + id.ToString() + ";";
            return ExecNonQuery(query);
        }
        #endregion
        #region Селекторный и неселекторный запросы
        public string ExecNonQuery(string query)
        {
            if(ExecutingQuery!=null)
                ExecutingNonQuery(query);
            try
            {
                SQLiteConnection sql = new SQLiteConnection(this.conString);
                SQLiteCommand com = new SQLiteCommand(query, sql);
                sql.Open();
                com.ExecuteNonQuery();
                sql.Close();
                return "";

            }
            catch(Exception e)
            {
                return "ExecNonQuery: " + e.Message;
            }
        }
        public object ExecQuery(string query)
        {
            if (ExecutingQuery != null)
                ExecutingQuery(query);
            try
            {
                SQLiteConnection sqlCon = new SQLiteConnection(this.conString);
                sqlCon.Open();
                SQLiteCommand sqlCom = new SQLiteCommand(sqlCon);
                sqlCom.CommandText = query;
                SQLiteDataReader sdr = sqlCom.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(sdr);
                sdr.Close();
                sqlCon.Close();
                return data;

            }
            catch(Exception e)
            {
                return "ExecQuery: " + e.Message;
            }
        }
#endregion
    }
}
