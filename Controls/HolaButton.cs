using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Controls
{
    public class HolaButton : Button
    {
        public int Count { get; set; }
        protected override void OnClick(EventArgs e)
        {
            Count++;
            base.OnClick(e);
        }
    }
}
