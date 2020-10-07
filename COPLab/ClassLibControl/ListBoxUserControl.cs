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
        private int _SelectedIndex;
        private event EventHandler _ComboBoxSelectedElementChenge;
        public  List<object> objList= new List<object>();
        public List<string> propPattern = new List<string>();
        public ListBoxUserControl()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => { _ComboBoxSelectedElementChenge?.Invoke(sender, e); };
        }

        public void SetPattern(string pattern)
        {
            foreach (var word in pattern.Split(' '))
            {
                propPattern.Add(word);
            }
        }
        
        public void AddClass(object cl)
        {
            objList.Add(cl);
        }
        public void LoadList()
        {
            try
            {
                foreach (var elem in objList)
                {
                    for (int i = elem.GetType().GetProperties().Length; i > 0; i--)
                    {
                        var pr = elem.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals(propPattern.First()));
                        listBox.Items.Add(pr.Name+" - "+pr.GetValue(elem));
                        propPattern.Remove(propPattern.First());
                    }

                }
            }
            catch
            {
                throw new Exception("No Pattern");
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Индекс элемента:" + listBox.SelectedIndex + "  Строка:" + listBox.SelectedItem.ToString());
        }
       
        [Category("Спецификации"), Description("Номер выбранного элемента")]
        public int _SelectIndex
        {
            get 
            {
                return _SelectedIndex;
            }

            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _SelectedIndex = value;
                    listBox.SelectedIndex = _SelectIndex;
                }
            }
        }

        [Category("Спецификации"), Description("Текст выбранной записи")]
        public string SelectText
        {
            get
            {
                return listBox.Text;
            }
        }

        [Category("Спецификации"), Description("Событие выбора элемента")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _ComboBoxSelectedElementChenge += value; }
            remove { _ComboBoxSelectedElementChenge -= value; }
        }
    }
}
