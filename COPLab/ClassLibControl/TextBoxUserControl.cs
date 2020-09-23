using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibControl
{
    public partial class TextBoxUserControl : UserControl
    {
        private Color _TextColor;
        public TextBoxUserControl()
        {
            InitializeComponent();
            toolTipPattern.SetToolTip(textBoxEmail, " petrov.ivan@gmail.com");
            toolTipPattern.ToolTipTitle = "Пример почты:";
            toolTipPattern.Active = true;
            toolTipPattern.ShowAlways = true;
            toolTipPattern.InitialDelay= 0;
            toolTipPattern.ReshowDelay = 1;
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [Category("Спецификации"), Description("Цвет подсветки текста, если он не соответсвует шаблону")]
        public Color SetColor
        {
            get
            {
                return textBoxEmail.ForeColor;
            }
            set
            {
                _TextColor = value;
            }
        }
        [Category("Спецификации"), Description("Введеная почта")]       
        public string GetText
        {
            get
            {
                if (IsValidEmail(textBoxEmail.Text))
                {
                    return textBoxEmail.Text;
                }
                else
                {
                    return "Почта не соответсвует шаблону.";
                }
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBoxEmail.Text))
            {              
                textBoxEmail.ForeColor = _TextColor;
            }
            else
            {
                textBoxEmail.ForeColor = Color.Black;
            }
        }
    }
}
