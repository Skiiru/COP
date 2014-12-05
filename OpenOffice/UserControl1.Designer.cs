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
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(25, 30);
            this.dgTable.Name = "dgTable";
            this.dgTable.Size = new System.Drawing.Size(555, 213);
            this.dgTable.TabIndex = 0;
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
            this.bCreateTable.Location = new System.Drawing.Point(706, 281);
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
            this.tbRows.Text = "Введите через запятую пары столбец -тип данных без пробелов";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(574, 281);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 8;
            // 
            // ecDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bCreateTable);
            this.Controls.Add(this.bOpenOrCreate);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.dgTable);
            this.Name = "ecDB";
            this.Size = new System.Drawing.Size(954, 392);
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
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
    }
}
