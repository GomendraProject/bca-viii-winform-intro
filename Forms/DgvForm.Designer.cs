using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class DgvForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        itemsDgv = new DataGridView();
        updateBtn = new Button();
        activeOnlyDgv = new DataGridView();
        ((ISupportInitialize)itemsDgv).BeginInit();
        ((ISupportInitialize)activeOnlyDgv).BeginInit();
        SuspendLayout();
        // 
        // itemsDgv
        // 
        itemsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        itemsDgv.Location = new Point(9, 164);
        itemsDgv.Margin = new Padding(3, 4, 3, 4);
        itemsDgv.Name = "itemsDgv";
        itemsDgv.RowHeadersWidth = 51;
        itemsDgv.Size = new Size(897, 387);
        itemsDgv.TabIndex = 0;
        // 
        // updateBtn
        // 
        updateBtn.BackColor = Color.DarkCyan;
        updateBtn.Font = new Font("Segoe UI", 18F);
        updateBtn.ForeColor = Color.Transparent;
        updateBtn.Location = new Point(202, 31);
        updateBtn.Margin = new Padding(3, 4, 3, 4);
        updateBtn.Name = "updateBtn";
        updateBtn.Size = new Size(461, 85);
        updateBtn.TabIndex = 1;
        updateBtn.Text = "Update";
        updateBtn.UseVisualStyleBackColor = false;
        // 
        // activeOnlyDgv
        // 
        activeOnlyDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        activeOnlyDgv.Location = new Point(912, 164);
        activeOnlyDgv.Name = "activeOnlyDgv";
        activeOnlyDgv.RowHeadersWidth = 51;
        activeOnlyDgv.Size = new Size(877, 387);
        activeOnlyDgv.TabIndex = 2;
        // 
        // DgvForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1801, 600);
        Controls.Add(activeOnlyDgv);
        Controls.Add(updateBtn);
        Controls.Add(itemsDgv);
        Margin = new Padding(3, 4, 3, 4);
        Name = "DgvForm";
        Text = "DgvForm";
        ((ISupportInitialize)itemsDgv).EndInit();
        ((ISupportInitialize)activeOnlyDgv).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView itemsDgv;
    private Button updateBtn;
    private DataGridView activeOnlyDgv;
}