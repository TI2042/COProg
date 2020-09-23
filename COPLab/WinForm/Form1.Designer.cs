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
            this.groupBox_ComboBox = new System.Windows.Forms.GroupBox();
            this.comboBoxUserControl1 = new ClassLibControl.ComboBoxUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUserControl1 = new ClassLibControl.TextBoxUserControl();
            this.buttonGetEmail = new System.Windows.Forms.Button();
            this.groupBox_ComboBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ComboBox
            // 
            this.groupBox_ComboBox.Controls.Add(this.comboBoxUserControl1);
            this.groupBox_ComboBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ComboBox.Name = "groupBox_ComboBox";
            this.groupBox_ComboBox.Size = new System.Drawing.Size(165, 62);
            this.groupBox_ComboBox.TabIndex = 1;
            this.groupBox_ComboBox.TabStop = false;
            this.groupBox_ComboBox.Text = "Выпадающий список";
            // 
            // comboBoxUserControl1
            // 
            this.comboBoxUserControl1._SelectIndex = 0;
            this.comboBoxUserControl1.Location = new System.Drawing.Point(6, 19);
            this.comboBoxUserControl1.Name = "comboBoxUserControl1";
            this.comboBoxUserControl1.Size = new System.Drawing.Size(150, 27);
            this.comboBoxUserControl1.TabIndex = 0;
            this.comboBoxUserControl1.ComboBoxSelectedElementChange += new System.EventHandler(this.comboBoxUserControl1_ComboBoxSelectedElementChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetEmail);
            this.groupBox1.Controls.Add(this.textBoxUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(192, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поле ввода почты";
            // 
            // textBoxUserControl1
            // 
            this.textBoxUserControl1.Location = new System.Drawing.Point(6, 12);
            this.textBoxUserControl1.Name = "textBoxUserControl1";
            this.textBoxUserControl1.SetColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserControl1.Size = new System.Drawing.Size(275, 30);
            this.textBoxUserControl1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_ComboBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibControl.ComboBoxUserControl comboBoxUserControl1;
        private System.Windows.Forms.GroupBox groupBox_ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private ClassLibControl.TextBoxUserControl textBoxUserControl1;
        private System.Windows.Forms.Button buttonGetEmail;
    }
}

