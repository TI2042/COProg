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
        public ListBoxUserControl()
        {
            InitializeComponent();
        }

        public void LoadList(Type cl)
        {
            foreach (var elem in cl.GetProperties())
            {
                listBox.Items.Add(elem.ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Индекс элемента:" + listBox.SelectedIndex + "  Строка:" + listBox.SelectedItem.ToString());
        }
    }
}
