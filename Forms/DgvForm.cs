using MySqlConnector;
using System.Data;
using System.Data.Common;

namespace WinFormsApp1.Forms;

public partial class DgvForm : Form
{
    private MySqlDataAdapter adapter;

    public DgvForm()
    {
        InitializeComponent();

        Load += DgvForm_Load;

        updateBtn.Click += delegate {
            adapter.Update((DataSet) itemsDgv.DataSource, "item_list");
            LoadData();
        };
    }

    private void DgvForm_Load(object? sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        var conn = new MySqlConnection(ConnectionStringProvider.GetConnectionString());
        var command = new MySqlCommand("SELECT * FROM item_list", conn);
        adapter = new MySqlDataAdapter(command);

        var dataset = new DataSet();

        adapter.Fill(dataset, "item_list");

        // Add this only in case of first item
        if (itemsDgv.Columns.Count == 0)
        {
            var column1 = new DataGridViewCheckBoxColumn();
            column1.Name = "IsActive";                         //Name of column
            column1.HeaderText = "Is Active";                //Title of column
            column1.DataPropertyName = "IsActive";         //Name of field in database
            column1.TrueValue = "1";                   //True value
            column1.FalseValue = "0";               //False Value
            itemsDgv.Columns.Add(column1);
        }

        new MySqlCommandBuilder(adapter);

        itemsDgv.DataSource = dataset;
        itemsDgv.DataMember = "item_list";

        // Data view
        var activeOnlyDataView = new DataView(dataset.Tables["item_list"]);
        activeOnlyDataView.RowFilter = "IsActive = 1";

        activeOnlyDgv.DataSource = activeOnlyDataView;

        // Stored Procedure

        //LoadCount();
    }

    private void LoadCount()
    {
        var conn = new MySqlConnection(ConnectionStringProvider.GetConnectionString());
        var command = new MySqlCommand("ItemCount", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new MySqlParameter()
        {
            Direction = System.Data.ParameterDirection.Input,
            ParameterName = "itemStatus",
            Value = 1
        });
        var itemCountParam = new MySqlParameter()
        {
            Direction = System.Data.ParameterDirection.Output,
            ParameterName = "itemCount",
            Value = 0
        };
        command.Parameters.Add(itemCountParam);

        conn.Open();
        command.ExecuteNonQuery();
        MessageBox.Show("Active item count: " + itemCountParam.Value);
    }
}