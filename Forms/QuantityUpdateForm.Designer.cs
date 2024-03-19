namespace WinFormsApp1.Forms
{
    partial class QuantityUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            QuantityElm = new TextBox();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // QuantityElm
            // 
            QuantityElm.Location = new Point(12, 37);
            QuantityElm.Name = "QuantityElm";
            QuantityElm.Size = new Size(305, 27);
            QuantityElm.TabIndex = 0;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(8, 110);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(309, 29);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // QuantityUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 162);
            Controls.Add(updateBtn);
            Controls.Add(QuantityElm);
            Name = "QuantityUpdateForm";
            Text = "Quantity Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuantityElm;
        private Button updateBtn;
    }
}