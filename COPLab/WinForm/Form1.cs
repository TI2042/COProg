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
            List<string> strList = new List<string> { "Элемент1", "Элемент2", "Элемент3", "Элемент4" };
            comboBoxUserControl1.LoadList(strList);           
            textBoxUserControl1.SetColor = Color.Red;
            TestClass testClass = new TestClass
            {
                Age = 19,
                Name = "Серега",
                SName = "Батькович"
            };
            TestClass2 testClass2 = new TestClass2
            {
                CarBrand = "Ford",
                Mileage = 123000,
                CarType = "hatchback"
            };
            listBoxUserControl1.SetPattern("SName Age Name CarBrand CarType Mileage");
            listBoxUserControl1.AddClass(testClass);
            listBoxUserControl1.AddClass(testClass2);
            listBoxUserControl1.LoadList();

        }

        private void comboBoxUserControl1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxUserControl1.SelectText);
        }

        private void buttonGetEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxUserControl1.GetText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxUserControl1._SelectIndex = 3;
            MessageBox.Show(listBoxUserControl1.SelectText);
        }
    }
}
