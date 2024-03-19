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
    public partial class QuantityUpdateForm : Form
    {
        public int SavedQuantity { get; protected set; }

        public QuantityUpdateForm(int quantity)
        {
            InitializeComponent();
            QuantityElm.Text = quantity.ToString();

            updateBtn.Click += UpdateBtn_Click;
        }

        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            if (Int32.TryParse(QuantityElm.Text, out int quantity))
            {
                SavedQuantity = quantity;
            }
            else SavedQuantity = 0;

            this.Close();
        }
    }
}
