using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxUserControl1.LoadEnumeration(typeof(TestEnum));
            
            textBoxUserControl1.SetColor = Color.Red;
            TestClass testClass = new TestClass();
            testClass.Age = 19;
            testClass.Name = "Серега";
            testClass.SName = "Батькович";

            listBoxUserControl1.LoadList(testClass);          
        }

        private void comboBoxUserControl1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxUserControl1.SelectText);
        }

        private void buttonGetEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxUserControl1.GetText);
        }

    }
}
