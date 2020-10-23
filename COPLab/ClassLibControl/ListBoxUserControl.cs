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
using System.Text.RegularExpressions;

namespace ClassLibControl
{
    public partial class ListBoxUserControl : UserControl
    {
        private int _SelectedIndex;
        private event EventHandler _ListBoxSelectedElementChenge;
        public  List<object> objList= new List<object>();
        public List<string> outputPattern = new List<string>();
        public List<string> propPattern = new List<string>();
        MatchCollection patt;
        public ListBoxUserControl()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => { _ListBoxSelectedElementChenge?.Invoke(sender, e); };
        }

        public void SetPattern(string pattern)
        {
            
            foreach (var word in Regex.Split(pattern, "\"[^\"]*\""))
            {
                outputPattern.Add(word);
            }
            patt = Regex.Matches(pattern, "\"[^\"]*\"");
            foreach (var p in patt)
            {
                propPattern.Add(p.ToString().Trim('"'));
            }
        }
        
        public void AddClass(object cl)
        {
            objList.Add(cl);
        }
        public void LoadList()
        {
            /*foreach (var p in patt)
            {
                listBox.Items.Add(p.ToString());
            }
            foreach (var p in propPattern)
            {
                listBox.Items.Add(p.ToString());
            }*/

            /*foreach (var elem in objList)
            {
                foreach (var i in elem.GetType().GetProperties())
                {
                    listBox.Items.Add(i.Name);
                }

            }*/
            try
            {
                foreach (var elem in objList)
                {
                    for (int i = elem.GetType().GetProperties().Length; i > 0; i--)
                    {

                        var pr = elem.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals(propPattern.First()));
                      
                        listBox.Items.Add(outputPattern.First() + pr?.GetValue(elem));
                        propPattern.Remove(propPattern.First());
                        outputPattern.Remove(outputPattern.First());
                        if(pr != null)
                        {
                            break;
                        }

                       
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
            add { _ListBoxSelectedElementChenge += value; }
            remove { _ListBoxSelectedElementChenge -= value; }
        }
    }
}
