using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class ReadonlyQuantityForm : Form
    {
        public ReadonlyQuantityForm()
        {
            InitializeComponent();
            QuantityElm.Text = "0";
            updateBtn.Click += UpdateBtn_Click;
        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            var currentQuantity = Convert.ToInt32(QuantityElm.Text);
            var updateForm = new QuantityUpdateForm(currentQuantity);
            updateForm.ShowDialog();
            QuantityElm.Text = updateForm.SavedQuantity.ToString();
        }
    }
}
