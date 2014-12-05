﻿using System;
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

        //private void SaveData(System.Windows.Forms.DataGridView dataGrid, string selectCommand)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(this.conString))
        //    {
        //        conn.Open();
        //        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCommand, this.conString);
        //        SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
        //        DataTable table = dataGrid.DataSource as DataTable;
        //        dataAdapter.Update(table);
        //        table.AcceptChanges();
        //    }
        //}

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
                        query += ')';
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
        public string Update(string tableName,int id, Dictionary<string,string> Columns)
        {
            try
            {
                int k = 0;
                string query = "Update " + tableName + " set ";
                foreach (KeyValuePair<string, string> kv in Columns)
                {
                    k++;
                    query += kv.Key + "=" + kv.Value;
                    if (k != Columns.Count)
                        query += ", ";
                    else
                    {
                        query += "where id=" + id.ToString() + ';';
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
                values += kv.Value;
                if(k<columns.Count)
                {
                    col += ", ";
                    values += ", ";
                }
            }
            string query = "INSERT INTO" + tableName + " columns("+col+" ) values(" + values+ ");";
            return ExecNonQuery(query);
        }
        public string Delete(string tableName, int id)
        {
            string query = "delete from " + tableName + " where id=" + id.ToString() + ";";
            return ExecNonQuery(query);
        }
        public string ExecNonQuery(string query)
        {
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
    }
}