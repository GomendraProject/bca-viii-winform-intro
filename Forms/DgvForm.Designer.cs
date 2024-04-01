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
        ((ISupportInitialize)itemsDgv).BeginInit();
        SuspendLayout();
        // 
        // itemsDgv
        // 
        itemsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        itemsDgv.Location = new Point(8, 123);
        itemsDgv.Name = "itemsDgv";
        itemsDgv.Size = new Size(785, 290);
        itemsDgv.TabIndex = 0;
        // 
        // updateBtn
        // 
        updateBtn.BackColor = Color.DarkCyan;
        updateBtn.Font = new Font("Segoe UI", 18F);
        updateBtn.ForeColor = Color.Transparent;
        updateBtn.Location = new Point(177, 23);
        updateBtn.Name = "updateBtn";
        updateBtn.Size = new Size(403, 64);
        updateBtn.TabIndex = 1;
        updateBtn.Text = "Update";
        updateBtn.UseVisualStyleBackColor = false;
        // 
        // DgvForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(updateBtn);
        Controls.Add(itemsDgv);
        Name = "DgvForm";
        Text = "DgvForm";
        ((ISupportInitialize)itemsDgv).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView itemsDgv;
    private Button updateBtn;
}