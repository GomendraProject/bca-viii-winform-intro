﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loginBtn = new Button();
            toolStrip1 = new ToolStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            userListElm = new ComboBox();
            textBox1 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(9, 391);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(443, 29);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "button1";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click_1;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 422);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(464, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // userListElm
            // 
            userListElm.FormattingEnabled = true;
            userListElm.Location = new Point(10, 42);
            userListElm.Name = "userListElm";
            userListElm.Size = new Size(442, 28);
            userListElm.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 27);
            textBox1.TabIndex = 3;
            textBox1.Validating += textBox1_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(textBox1);
            Controls.Add(userListElm);
            Controls.Add(toolStrip1);
            Controls.Add(loginBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ComboBox userListElm;
        private TextBox textBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
