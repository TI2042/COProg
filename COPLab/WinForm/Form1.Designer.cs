namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_ComboBox = new System.Windows.Forms.GroupBox();
            this.comboBoxUserControl1 = new ClassLibControl.ComboBoxUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetEmail = new System.Windows.Forms.Button();
            this.textBoxUserControl1 = new ClassLibControl.TextBoxUserControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxUserControl1 = new ClassLibControl.ListBoxUserControl();
            this.button1 = new System.Windows.Forms.Button();
            this.saveToPdf1 = new ClassLibNonVisualComponents.SaveToPdf(this.components);
            this.saveToJson1 = new ClassLibNonVisualComponents.SaveToJson(this.components);
            this.saveToExcel1 = new ClassLibNonVisualComponents.SaveToExcel(this.components);
            this.groupBox_ComboBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ComboBox
            // 
            this.groupBox_ComboBox.Controls.Add(this.comboBoxUserControl1);
            this.groupBox_ComboBox.Location = new System.Drawing.Point(21, 19);
            this.groupBox_ComboBox.Name = "groupBox_ComboBox";
            this.groupBox_ComboBox.Size = new System.Drawing.Size(296, 62);
            this.groupBox_ComboBox.TabIndex = 1;
            this.groupBox_ComboBox.TabStop = false;
            this.groupBox_ComboBox.Text = "Выпадающий список";
            // 
            // comboBoxUserControl1
            // 
            this.comboBoxUserControl1._SelectIndex = 0;
            this.comboBoxUserControl1.Location = new System.Drawing.Point(6, 19);
            this.comboBoxUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUserControl1.Name = "comboBoxUserControl1";
            this.comboBoxUserControl1.Size = new System.Drawing.Size(284, 27);
            this.comboBoxUserControl1.TabIndex = 0;
            this.comboBoxUserControl1.ComboBoxSelectedElementChange += new System.EventHandler(this.comboBoxUserControl1_ComboBoxSelectedElementChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetEmail);
            this.groupBox1.Controls.Add(this.textBoxUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(322, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поле ввода почты";
            // 
            // buttonGetEmail
            // 
            this.buttonGetEmail.Location = new System.Drawing.Point(6, 57);
            this.buttonGetEmail.Name = "buttonGetEmail";
            this.buttonGetEmail.Size = new System.Drawing.Size(275, 42);
            this.buttonGetEmail.TabIndex = 1;
            this.buttonGetEmail.Text = "Полученипе почты";
            this.buttonGetEmail.UseVisualStyleBackColor = true;
            this.buttonGetEmail.Click += new System.EventHandler(this.buttonGetEmail_Click);
            // 
            // textBoxUserControl1
            // 
            this.textBoxUserControl1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserControl1.Location = new System.Drawing.Point(6, 12);
            this.textBoxUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserControl1.Name = "textBoxUserControl1";
            this.textBoxUserControl1.SetColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserControl1.Size = new System.Drawing.Size(275, 30);
            this.textBoxUserControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxUserControl1);
            this.groupBox2.Location = new System.Drawing.Point(643, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 309);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список значений";
            // 
            // listBoxUserControl1
            // 
            this.listBoxUserControl1._SelectIndex = 0;
            this.listBoxUserControl1.Location = new System.Drawing.Point(5, 13);
            this.listBoxUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxUserControl1.Name = "listBoxUserControl1";
            this.listBoxUserControl1.Size = new System.Drawing.Size(223, 291);
            this.listBoxUserControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_ComboBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibControl.ComboBoxUserControl comboBoxUserControl1;
        private System.Windows.Forms.GroupBox groupBox_ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private ClassLibControl.TextBoxUserControl textBoxUserControl1;
        private System.Windows.Forms.Button buttonGetEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private ClassLibControl.ListBoxUserControl listBoxUserControl1;
        private System.Windows.Forms.Button button1;
        private ClassLibNonVisualComponents.SaveToPdf saveToPdf1;
        private ClassLibNonVisualComponents.SaveToJson saveToJson1;
        private ClassLibNonVisualComponents.SaveToExcel saveToExcel1;
    }
}

