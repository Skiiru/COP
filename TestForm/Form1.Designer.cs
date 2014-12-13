namespace TestForm
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ecDB1 = new OpenOffice.ecDB();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.tbTableTitle = new System.Windows.Forms.TextBox();
            this.openOfficeComponent1 = new OpenOfficeLib.OpenOfficeComponent(this.components);
            this.SuspendLayout();
            // 
            // ecDB1
            // 
            this.ecDB1.CreateTableBtnText = "Create table";
            this.ecDB1.Location = new System.Drawing.Point(12, 12);
            this.ecDB1.Name = "ecDB1";
            this.ecDB1.OpenOrCreateBtnText = "Open or create";
            this.ecDB1.Size = new System.Drawing.Size(1012, 354);
            this.ecDB1.TabIndex = 0;
            this.ecDB1.UpdateBtnText = "Update";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "test.ods";
            this.openFileDialog1.Filter = "ODS(*.ods)|*ods";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "test.ods";
            this.saveFileDialog1.Filter = "ODS(*.ods)|*ods";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(34, 407);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(100, 20);
            this.tbTableName.TabIndex = 2;
            // 
            // tbTableTitle
            // 
            this.tbTableTitle.Location = new System.Drawing.Point(176, 407);
            this.tbTableTitle.Name = "tbTableTitle";
            this.tbTableTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTableTitle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 463);
            this.Controls.Add(this.tbTableTitle);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ecDB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenOffice.ecDB ecDB1;
        private OpenOfficeLib.OpenOfficeComponent openOfficeComponent1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.TextBox tbTableTitle;
    }
}

