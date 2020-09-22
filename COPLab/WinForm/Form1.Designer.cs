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
            this.comboBoxUserControl1 = new ClassLibControl.ComboBoxUserControl();
            this.groupBox_ComboBox = new System.Windows.Forms.GroupBox();
            this.groupBox_ComboBox.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox_ComboBox
            // 
            this.groupBox_ComboBox.Controls.Add(this.comboBoxUserControl1);
            this.groupBox_ComboBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ComboBox.Name = "groupBox_ComboBox";
            this.groupBox_ComboBox.Size = new System.Drawing.Size(165, 62);
            this.groupBox_ComboBox.TabIndex = 1;
            this.groupBox_ComboBox.TabStop = false;
            this.groupBox_ComboBox.Text = "Combo Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_ComboBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibControl.ComboBoxUserControl comboBoxUserControl1;
        private System.Windows.Forms.GroupBox groupBox_ComboBox;
    }
}

