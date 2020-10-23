using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNonVisualComponents
{
    public partial class BackUpComponent : Component
    {
        public BackUpComponent()
        {
            InitializeComponent();
        }

        public BackUpComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


    }
}
