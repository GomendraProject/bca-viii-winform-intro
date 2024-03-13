namespace WinFormsApp1.Forms
{
    partial class FileInfoForm
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
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(286, 330);
            button1.Name = "button1";
            button1.Size = new Size(188, 53);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(56, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 265);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FileInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "FileInfoForm";
            Text = "FileInfoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
    }
}