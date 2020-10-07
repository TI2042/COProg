using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace ClassLibControl
{
    public partial class ListBoxUserControl : UserControl
    {
        public  List<object> objList= new List<object>();
        public List<string> propPattern = new List<string>();
        public ListBoxUserControl()
        {
            InitializeComponent();
        }

        public void GetPattern(object cl)
        {
            textBox.Text = "Age Name SName";
            if (textBox.Text == "")
            {
                foreach(var elem in cl.GetType().GetProperties())
                {
                    propPattern.Add(elem.Name);
                }
            }
            else
            {
                foreach (var word in textBox.Text.Split(' '))
                {
                    propPattern.Add(word);
                }
            }
        }
        public void LoadList(object cl)
        {
            GetPattern(cl);
            objList.Add(cl);
            foreach (var elem in objList)
            {
                foreach (var p in elem.GetType().GetProperties())
                {
                    while (!(propPattern.Count == 0)) 
                    {
                        if(p.GetValue(elem).Equals(propPattern.First()))
                        { 
                            listBox.Items.Add(p.GetValue(elem));
                            propPattern.Remove(propPattern.First());
                        }
                    }
                }              
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Индекс элемента:" + listBox.SelectedIndex + "  Строка:" + listBox.SelectedItem.ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var word in textBox.Text.Split(' '))
            {
                propPattern.Add(word);
            }
        }
    }
}
