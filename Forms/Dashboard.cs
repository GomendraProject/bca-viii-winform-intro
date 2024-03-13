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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            AttachEventListeners();
        }

        private void AttachEventListeners()
        {
            loadMenuItemElm.Click += LoadMenuItemElm_Click;
            newFileElm.Click += NewFileElm_Click;
        }

        private void NewFileElm_Click(object? sender, EventArgs e)
        {
            var formElm = new NewFileForm();
            formElm.MdiParent = this;
            formElm.Show();

        }

        private void LoadMenuItemElm_Click(object? sender, EventArgs e)
        {
            var formElm = new FileInfoForm();
            formElm.MdiParent = this;
            formElm.Show();
        }
    }
}
