using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class FirstRunControl : UserControl
    {
        public string Value
        {
            get
            {
                return inputElm.Text;
            }
            set
            {
                inputElm.Text = value;
            }
        }
        public FirstRunControl(string label, string value)
        {
            InitializeComponent();
            labelElm.Text = label;
            inputElm.Text = value;
            clearBtn.Click += delegate {
                inputElm.Text = "";
            };
        }
    }
}
