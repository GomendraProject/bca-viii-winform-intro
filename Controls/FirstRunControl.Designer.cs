namespace WinFormsApp1.Controls
{
    partial class FirstRunControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputElm = new TextBox();
            labelElm = new Label();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // inputElm
            // 
            inputElm.Location = new Point(12, 28);
            inputElm.Name = "inputElm";
            inputElm.Size = new Size(125, 27);
            inputElm.TabIndex = 0;
            // 
            // labelElm
            // 
            labelElm.AutoSize = true;
            labelElm.Location = new Point(12, 5);
            labelElm.Name = "labelElm";
            labelElm.Size = new Size(50, 20);
            labelElm.TabIndex = 1;
            labelElm.Text = "label1";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(153, 27);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(60, 29);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "X";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // FirstRunControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearBtn);
            Controls.Add(labelElm);
            Controls.Add(inputElm);
            Name = "FirstRunControl";
            Size = new Size(216, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputElm;
        private Label labelElm;
        private Button clearBtn;
    }
}
