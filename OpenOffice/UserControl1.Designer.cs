namespace OpenOffice
{
    partial class ecDB
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.bOpenOrCreate = new System.Windows.Forms.Button();
            this.bCreateTable = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.ofdDbPath = new System.Windows.Forms.OpenFileDialog();
            this.sfdDbPath = new System.Windows.Forms.SaveFileDialog();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbColumnsTip = new System.Windows.Forms.Label();
            this.lbTbName = new System.Windows.Forms.Label();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.cbColumnName = new System.Windows.Forms.ComboBox();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbColumn = new System.Windows.Forms.Label();
            this.dgCondition = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bDeleteTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCondition)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(25, 30);
            this.dgTable.Name = "dgTable";
            this.dgTable.Size = new System.Drawing.Size(555, 213);
            this.dgTable.TabIndex = 0;
            this.dgTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgTable_UserDeletingRow);
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(595, 63);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 1;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // bOpenOrCreate
            // 
            this.bOpenOrCreate.Location = new System.Drawing.Point(595, 30);
            this.bOpenOrCreate.Name = "bOpenOrCreate";
            this.bOpenOrCreate.Size = new System.Drawing.Size(121, 23);
            this.bOpenOrCreate.TabIndex = 2;
            this.bOpenOrCreate.Text = "Open or create";
            this.bOpenOrCreate.UseVisualStyleBackColor = true;
            this.bOpenOrCreate.Click += new System.EventHandler(this.bOpenOrCreate_Click);
            // 
            // bCreateTable
            // 
            this.bCreateTable.Location = new System.Drawing.Point(140, 317);
            this.bCreateTable.Name = "bCreateTable";
            this.bCreateTable.Size = new System.Drawing.Size(75, 23);
            this.bCreateTable.TabIndex = 3;
            this.bCreateTable.Text = "Create table";
            this.bCreateTable.UseVisualStyleBackColor = true;
            this.bCreateTable.Click += new System.EventHandler(this.bCreateTable_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(595, 90);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(63, 20);
            this.bUpdate.TabIndex = 6;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // ofdDbPath
            // 
            this.ofdDbPath.DefaultExt = "sqlite";
            this.ofdDbPath.FileName = "db.sqlite";
            this.ofdDbPath.Filter = "БД (*.sqlite)|*sqlite";
            this.ofdDbPath.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdDbPath_FileOk);
            // 
            // sfdDbPath
            // 
            this.sfdDbPath.DefaultExt = "sqlite";
            this.sfdDbPath.FileName = "db.sqlite";
            this.sfdDbPath.Filter = "БД (*.sqlite)|*sqlite";
            this.sfdDbPath.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdDbPath_FileOk);
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(25, 280);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(527, 20);
            this.tbRows.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(25, 320);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 8;
            // 
            // lbColumnsTip
            // 
            this.lbColumnsTip.AutoSize = true;
            this.lbColumnsTip.Location = new System.Drawing.Point(25, 261);
            this.lbColumnsTip.Name = "lbColumnsTip";
            this.lbColumnsTip.Size = new System.Drawing.Size(334, 13);
            this.lbColumnsTip.TabIndex = 9;
            this.lbColumnsTip.Text = "Введите через запятую пары столбец -тип данных без пробелов";
            // 
            // lbTbName
            // 
            this.lbTbName.AutoSize = true;
            this.lbTbName.Location = new System.Drawing.Point(25, 304);
            this.lbTbName.Name = "lbTbName";
            this.lbTbName.Size = new System.Drawing.Size(63, 13);
            this.lbTbName.TabIndex = 10;
            this.lbTbName.Text = "Table name";
            this.lbTbName.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCondition
            // 
            this.tbCondition.Location = new System.Drawing.Point(4, 69);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(100, 20);
            this.tbCondition.TabIndex = 11;
            this.tbCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCondition_KeyPress);
            // 
            // cbColumnName
            // 
            this.cbColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumnName.FormattingEnabled = true;
            this.cbColumnName.Location = new System.Drawing.Point(3, 29);
            this.cbColumnName.Name = "cbColumnName";
            this.cbColumnName.Size = new System.Drawing.Size(121, 21);
            this.cbColumnName.TabIndex = 12;
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Location = new System.Drawing.Point(3, 53);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(51, 13);
            this.lbCondition.TabIndex = 13;
            this.lbCondition.Text = "Condition";
            // 
            // lbColumn
            // 
            this.lbColumn.AutoSize = true;
            this.lbColumn.Location = new System.Drawing.Point(3, 13);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(42, 13);
            this.lbColumn.TabIndex = 14;
            this.lbColumn.Text = "Column";
            // 
            // dgCondition
            // 
            this.dgCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCondition.Location = new System.Drawing.Point(6, 111);
            this.dgCondition.Name = "dgCondition";
            this.dgCondition.ReadOnly = true;
            this.dgCondition.Size = new System.Drawing.Size(267, 216);
            this.dgCondition.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbColumnName);
            this.panel1.Controls.Add(this.dgCondition);
            this.panel1.Controls.Add(this.lbColumn);
            this.panel1.Controls.Add(this.tbCondition);
            this.panel1.Controls.Add(this.lbCondition);
            this.panel1.Location = new System.Drawing.Point(732, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 349);
            this.panel1.TabIndex = 16;
            // 
            // bDeleteTable
            // 
            this.bDeleteTable.Location = new System.Drawing.Point(221, 318);
            this.bDeleteTable.Name = "bDeleteTable";
            this.bDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.bDeleteTable.TabIndex = 17;
            this.bDeleteTable.Text = "Delete table";
            this.bDeleteTable.UseVisualStyleBackColor = true;
            this.bDeleteTable.Click += new System.EventHandler(this.bDeleteTable_Click);
            // 
            // ecDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bDeleteTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTbName);
            this.Controls.Add(this.lbColumnsTip);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bCreateTable);
            this.Controls.Add(this.bOpenOrCreate);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.dgTable);
            this.Name = "ecDB";
            this.Size = new System.Drawing.Size(1084, 374);
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCondition)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button bOpenOrCreate;
        private System.Windows.Forms.Button bCreateTable;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.OpenFileDialog ofdDbPath;
        private System.Windows.Forms.SaveFileDialog sfdDbPath;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbColumnsTip;
        private System.Windows.Forms.Label lbTbName;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.ComboBox cbColumnName;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbColumn;
        private System.Windows.Forms.DataGridView dgCondition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bDeleteTable;
    }
}
