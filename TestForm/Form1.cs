using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ecDB1.ConditionResult.Rows.Count>0)
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Вы хотите создать файл?", "Создание или открытие файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                string path = string.Empty;
                if (res == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    path = @saveFileDialog1.FileName;
                }
                else
                {
                    openFileDialog1.ShowDialog();
                    path = @openFileDialog1.FileName;
                }
                if(res==DialogResult.Cancel)
                {
                    return;
                }
                Dictionary<int,List<string>> data = new Dictionary<int,List<string>>();
                List<string> rows = new List<string>();
                for(int i=0;i<this.ecDB1.ConditionResult.Columns.Count;++i)
                {
                    for(int j=0;j<this.ecDB1.ConditionResult.Rows.Count;++j)
                    {
                        rows.Add(this.ecDB1.ConditionResult.Rows[j][i].ToString());
                    }
                    data.Add(i,rows.ToList<string>());
                    rows.Clear();
                }
                this.openOfficeComponent1.CreateDocument(path, this.tbTableName.Text, this.tbTableTitle.Text, data);
            }
        }
    }
}
