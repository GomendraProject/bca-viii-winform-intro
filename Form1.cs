using MySqlConnector;
using System.Windows.Forms;
using WinFormsApp1.Controls;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : BaseForm
    {
        // Declare the ContextMenuStrip control.

        public Form1()
        {
            InitializeComponent();
            loginBtn.Text = "OK";

            loginBtn.Click += LoginBtn_Click;

            AddContextMenu();


            AddMenu();

            BindUserList();

            var x = new FirstRunControl("Item", "Value");
            x.Location = new Point(Top, 40);
            this.Controls.Add(x);

        }

        private void BindUserList()
        {
            var userList = new List<User>()
            {
                new User()
                {
                    Id = 1, UsernameUpdated = "A"
                },
                new User()
                {
                    Id = 2, UsernameUpdated = "B"
                },
                new User()
                {
                    Id = 3, UsernameUpdated = "C"
                },
            };

            userListElm.DataSource = userList;
            userListElm.DisplayMember = nameof(User.UsernameUpdated);
            userListElm.ValueMember = nameof(User.Id);
        }

        private void AddContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Itemx"));
            contextMenu.Items.Add(new ToolStripMenuItem("Itemy"));
            contextMenu.Items.Add(new ToolStripMenuItem("Itemz"));
            this.ContextMenuStrip = contextMenu;

            var contextMenu2 = new ContextMenuStrip();
            contextMenu2.Items.Add(new ToolStripMenuItem("Button Itemx"));
            contextMenu2.Items.Add(new ToolStripMenuItem("Button Itemy"));
            contextMenu2.Items.Add(new ToolStripMenuItem("Button Itemz"));
            loginBtn.ContextMenuStrip = contextMenu2;
        }

        private void AddMenu()
        {
            var menuStrip = new MenuStrip();
            var item1 = new ToolStripMenuItem("File");

            var newMenu = new ToolStripMenuItem("New");

            var newFileItem = new ToolStripMenuItem("New File");
            var newProjectItem = new ToolStripMenuItem("New Project");

            var aboutItem = new ToolStripMenuItem("About");

            item1.DropDownItems.Add(newMenu);
            newMenu.DropDownItems.Add(newFileItem);
            newMenu.DropDownItems.Add(newProjectItem);

            menuStrip.Items.Add(item1);
            menuStrip.Items.Add(aboutItem);
            menuStrip.Dock = DockStyle.Top;
            MainMenuStrip = menuStrip;

            this.Controls.Add(menuStrip);

            aboutItem.Click += delegate
            {
                MessageBox.Show("About");
            };

            newFileItem.Click += delegate
            {
                var formElm = new Dashboard();
                this.Hide();
                formElm.ShowDialog(this);
                this.Show();
            };
        }

        private void LoginBtn_Click(object? sender, EventArgs e)
        {
            var quantityForm = new ReadonlyQuantityForm();
            quantityForm.ShowDialog();

            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Login clicked");

                using (var conn = new MySqlConnection(ConnectionStringProvider.GetConnectionString()))
                {
                    var query = "UPDATE login_information SET LoginCount = LoginCount + 1 WHERE Id = @id";
                    conn.Open();
                    var command = new MySqlCommand(query, conn);
                    command.Parameters.Add(new MySqlParameter()
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        ParameterName = "id",
                        Value = 1
                    });
                    command.ExecuteNonQuery();
                }
                // For Read
                using (var conn = new MySqlConnection(ConnectionStringProvider.GetConnectionString()))
                {
                    var query = "SELECT * FROM login_information";
                    conn.Open();
                    var command = new MySqlCommand(query, conn);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var count = reader.GetInt32("LoginCount");
                        MessageBox.Show($"Id: {id}, Count: {count}");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(textBox1.Text == "not_valid")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Invalid data");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }
    }
}
