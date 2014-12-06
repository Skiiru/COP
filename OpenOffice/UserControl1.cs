using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenOffice
{
    public partial class ecDB: UserControl
    {
        DB db;
        List<int> forDel;
        public DataGridView Data
        {
            get { return this.dgTable; }
        }

        public ecDB()
        {
            InitializeComponent();
            forDel = new List<int>();
        }

        #region События
        #endregion

        #region Кнопки
        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = cbTable.SelectedItem.ToString();
                DataTable dt = dgTable.DataSource as DataTable;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    //int id = Convert.ToInt32(dt.Rows[i]["ID"]);
                    if (dt.Rows[i].RowState == DataRowState.Modified)
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();
                        for(int j=1;j<dt.Columns.Count;++j)
                        {
                            //MessageBox.Show(dt.Columns[j].ColumnName +' ' + dt.Rows[i][j].ToString());
                            values.Add(dt.Columns[j].ColumnName, dt.Rows[i][j].ToString());
                        }
                        //[0] - id
                        db.Update(tableName, Convert.ToInt32(dt.Rows[i]["ID"]), values);
                    }
                    if (dt.Rows[i].RowState == DataRowState.Added)
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();
                        for (int j = 1; j < dt.Columns.Count; ++j)
                        {
                            //MessageBox.Show(dt.Columns[j].ColumnName +' ' + dt.Rows[i][j].ToString());
                            values.Add(dt.Columns[j].ColumnName, dt.Rows[i][j].ToString());
                        }
                        db.Insert(tableName, values);
                    }
                    foreach(var id in forDel)
                    {
                        db.Delete(tableName, id);
                    }
                    forDel.Clear();
                }
                MessageBox.Show("Данные были успешно изменены");
            }
                catch (Exception ex)
            {
                    MessageBox.Show("Update Button error:"+ex.Message);
                }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
        }

        private void bCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                string[] rows = tbRows.Text.Split(',');
                Dictionary<string, string> forTbCreate = new Dictionary<string, string>();
                for (int i = 0; i < rows.Count(); ++i)
                {
                    string[] data = rows[i].Split('-');
                    //data[0] - имя столбца, data[1] - тип данных
                    forTbCreate.Add(data[0], data[1]);
                }
                string flag = db.CreateTable(tbName.Text, forTbCreate);
                if (flag != "")
                    throw new Exception(flag);
                MessageBox.Show("Таблица создана успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CreateTabeleErr: " + ex.Message);
            }
        }

        private void bOpenOrCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Вы хотите создать файл?", "Создание или открытие файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    sfdDbPath.ShowDialog();
                    db = new DB(@sfdDbPath.FileName);
                }
                else
                {
                    ofdDbPath.ShowDialog();
                    db = new DB(@ofdDbPath.FileName);
                }
                cbTable.Items.Clear();
                try
                {
                    object tbNamesOrErr = db.GetTableNames();
                    if (tbNamesOrErr is string)
                    {
                        MessageBox.Show(tbNamesOrErr as string);
                    }
                    else
                    {
                        if ((tbNamesOrErr as List<string>).Count > 0)
                        {
                            foreach (string s in tbNamesOrErr as List<string>)
                            {
                                cbTable.Items.Add(s);
                            }
                        }
                        else
                        {
                            MessageBox.Show("В данной ДБ нет таблиц");
                        }
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion 


        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            object dt = db.OpenTable(cbTable.SelectedItem.ToString());
            if (dt is DataTable)
                dgTable.DataSource = dt;
            else
                MessageBox.Show("Что-то пошло не так");
        }

        private void ofdDbPath_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void sfdDbPath_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                forDel.Add(Convert.ToInt32(e.Row.Cells["ID"].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
