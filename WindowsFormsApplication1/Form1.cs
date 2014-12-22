using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenOfficeLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int[,] ar = new int[5,5];
            for(int i=0;i<ar.GetLength(0);++i)
                for(int j=0;j<ar.GetLength(1);++j)
                {
                    ar[i, j] = R.Next(100);
                }
            Data tbNaMe = new Data("Table","","");
            Dictionary<int,List<Data>> data = new Dictionary<int,List<Data>>();
            List<Data> dt = new List<Data>();
            for(int i=0;i<ar.GetLength(0);++i)
            {
                dt.Clear();
                for(int j=0;j<ar.GetLength(1);++j)
                {
                    dt.Add(new Data(ar[i,j].ToString(),"",""));
                }
                data.Add(i+1,dt);
            }
            //saveFileDialog1.ShowDialog();
            MessageBox.Show(this.openOfficeComponent1.CreateDocument("D://1.ods", "Лист 1", tbNaMe, data));
        }
    }
}
