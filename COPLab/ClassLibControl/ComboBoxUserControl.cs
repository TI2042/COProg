using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibControl
{
    public partial class ComboBoxUserControl : UserControl
    {
        private int _SelectedIndex;
        private event EventHandler _ComboBoxSelectedElementChenge;
        [Category("Спецификации"), Description("Номер выбранного элемента")]
        public int _SelectIndex
        {
            get 
            {
                return _SelectedIndex;
            }

            set
            {
                if (value > -2 && value < comboBox.Items.Count)
                {
                    _SelectedIndex = value;
                    comboBox.SelectedIndex = _SelectIndex;
                }
            }
        }

        [Category("Спецификации"), Description("Текст выбранной записи")]
        public string SelectText
        {
            get
            {
                return comboBox.Text;
            }
        }

        [Category("Спецификации"), Description("Событие выбора элемента")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _ComboBoxSelectedElementChenge += value; }
            remove { _ComboBoxSelectedElementChenge -= value; }
        }

        public ComboBoxUserControl()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => { _ComboBoxSelectedElementChenge?.Invoke(sender, e); };
        }

        public void LoadList (List<string> list)
        {
            foreach (var elem in list)
            {
                comboBox.Items.Add(elem.ToString());
            }
        }
    }
}
