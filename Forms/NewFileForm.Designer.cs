namespace WinFormsApp1.Forms
{
    partial class NewFileForm
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Location = new Point(12, 252);
            button1.Name = "button1";
            button1.Size = new Size(776, 50);
            button1.TabIndex = 0;
            button1.Text = "Create new file";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 188);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Add new data";
            // 
            // NewFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 319);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "NewFileForm";
            Text = "NewFileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}