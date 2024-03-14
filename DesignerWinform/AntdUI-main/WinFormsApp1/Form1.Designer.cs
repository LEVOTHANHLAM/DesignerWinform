// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntdUI PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITEE: https://gitee.com/antdui/AntdUI
// GITHUB: https://github.com/AntdUI/AntdUI
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

namespace WinFormsApp1
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
            panel25 = new Panel();
            label12 = new Label();
            label1 = new Label();
            panel25.SuspendLayout();
            SuspendLayout();
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.Controls.Add(label1);
            panel25.Dock = DockStyle.Right;
            panel25.Location = new Point(265, 0);
            panel25.Name = "panel25";
            panel25.Size = new Size(535, 450);
            panel25.TabIndex = 104;
            panel25.Paint += panel25_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(12, 32);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 105;
            label12.Text = "Literary style :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 101;
            label1.Text = "Literary style :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 235, 250);
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(panel25);
            Name = "Form1";
            Text = "Form1";
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel25;
        private Label label1;
        private Label label12;
    }
}
