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

namespace DesignerWinform
{
    partial class Main
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
            btn_mode = new AntdUI.Button();
            divider2 = new AntdUI.Divider();
            windowBar = new AntdUI.WindowBar();
            tabs1 = new AntdUI.Tabs();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            table1 = new AntdUI.Table();
            contextMenuStrip1 = new ContextMenuStrip(components);
            selecToolStripMenuItem = new ToolStripMenuItem();
            huyChonToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            input9 = new AntdUI.Input();
            button2 = new AntdUI.Button();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            select6 = new AntdUI.Select();
            button16 = new AntdUI.Button();
            button17 = new AntdUI.Button();
            tabPage2 = new TabPage();
            label2 = new Label();
            tabPage3 = new TabPage();
            label3 = new Label();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            windowBar.SuspendLayout();
            tabs1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_mode
            // 
            btn_mode.Dock = DockStyle.Right;
            btn_mode.Font = new Font("Microsoft YaHei UI", 18F);
            btn_mode.Ghost = true;
            btn_mode.ImageSvg = Properties.Resources.app_light;
            btn_mode.Location = new Point(1106, 0);
            btn_mode.Margins = 0;
            btn_mode.Name = "btn_mode";
            btn_mode.Radius = 0;
            btn_mode.Size = new Size(50, 32);
            btn_mode.TabIndex = 6;
            btn_mode.Click += btn_mode_Click;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(0, 32);
            divider2.Name = "divider2";
            divider2.Size = new Size(1300, 10);
            divider2.TabIndex = 0;
            // 
            // windowBar
            // 
            windowBar.Controls.Add(btn_mode);
            windowBar.Dock = DockStyle.Top;
            windowBar.Icon = Properties.Resources.logo;
            windowBar.Location = new Point(0, 0);
            windowBar.Name = "windowBar";
            windowBar.Size = new Size(1300, 32);
            windowBar.SubText = "Overview";
            windowBar.TabIndex = 0;
            windowBar.Text = "ccc";
            // 
            // tabs1
            // 
            tabs1.Appearance = TabAppearance.FlatButtons;
            tabs1.Controls.Add(tabPage1);
            tabs1.Controls.Add(tabPage2);
            tabs1.Controls.Add(tabPage3);
            tabs1.Controls.Add(tabPage5);
            tabs1.Controls.Add(tabPage6);
            tabs1.Dock = DockStyle.Fill;
            tabs1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabs1.ItemSize = new Size(80, 54);
            tabs1.Location = new Point(0, 42);
            tabs1.Name = "tabs1";
            tabs1.SelectedIndex = 0;
            tabs1.Size = new Size(1300, 678);
            tabs1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 58);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1292, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(table1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 570);
            panel2.TabIndex = 2;
            // 
            // table1
            // 
            table1.Bordered = true;
            table1.ContextMenuStrip = contextMenuStrip1;
            table1.Dock = DockStyle.Fill;
            table1.Font = new Font("Microsoft YaHei UI", 11F);
            table1.Location = new Point(0, 0);
            table1.Name = "table1";
            table1.Size = new Size(1286, 570);
            table1.TabIndex = 1;
            table1.Text = "table1";
            table1.CellButtonClick += table1_CellButtonClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { selecToolStripMenuItem, huyChonToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            // 
            // selecToolStripMenuItem
            // 
            selecToolStripMenuItem.Name = "selecToolStripMenuItem";
            selecToolStripMenuItem.Size = new Size(126, 22);
            selecToolStripMenuItem.Text = "Selec";
            // 
            // huyChonToolStripMenuItem
            // 
            huyChonToolStripMenuItem.Name = "huyChonToolStripMenuItem";
            huyChonToolStripMenuItem.Size = new Size(126, 22);
            huyChonToolStripMenuItem.Text = "Huy chon";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button17);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 5, 0);
            panel1.Size = new Size(1286, 40);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(panel8);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(512, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 40);
            panel3.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = Properties.Resources.icons8_minus_35;
            pictureBox2.Location = new Point(437, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.icons8_add_35__1_;
            pictureBox1.Location = new Point(398, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(input9);
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(519, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 40);
            panel6.TabIndex = 14;
            panel6.Text = "panel4";
            // 
            // input9
            // 
            input9.Dock = DockStyle.Fill;
            input9.JoinRight = true;
            input9.Location = new Point(0, 0);
            input9.Margins = 6;
            input9.Name = "input9";
            input9.PlaceholderText = "Search";
            input9.Size = new Size(200, 40);
            input9.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Right;
            button2.ImageSvg = Properties.Resources.icon_search;
            button2.JoinLeft = true;
            button2.Location = new Point(200, 0);
            button2.Margins = 6;
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 1;
            button2.Type = AntdUI.TTypeMini.Primary;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = Properties.Resources.icons8_transfer_35;
            pictureBox3.Location = new Point(476, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(select6);
            panel8.Location = new Point(136, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 40);
            panel8.TabIndex = 15;
            panel8.Text = "panel4";
            // 
            // select6
            // 
            select6.AllowClear = true;
            select6.Dock = DockStyle.Fill;
            select6.Items.AddRange(new object[] { "Lucy", "Tom", "AduSkin", "WangLi", "HUAWEI", "XIAOMI" });
            select6.JoinRight = true;
            select6.Location = new Point(0, 0);
            select6.Margins = 6;
            select6.Name = "select6";
            select6.PlaceholderText = "";
            select6.Size = new Size(250, 40);
            select6.TabIndex = 0;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Left;
            button16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button16.Location = new Point(151, 0);
            button16.Name = "button16";
            button16.Size = new Size(146, 40);
            button16.TabIndex = 13;
            button16.Text = "Stop";
            button16.Type = AntdUI.TTypeMini.Error;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Left;
            button17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.Black;
            button17.Location = new Point(5, 0);
            button17.Name = "button17";
            button17.Size = new Size(146, 40);
            button17.TabIndex = 12;
            button17.Text = "Start";
            button17.Type = AntdUI.TTypeMini.Success;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 58);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1292, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "Tab 2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 58);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1292, 616);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Script";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 1;
            label3.Text = "Tab 3";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 58);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1292, 616);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "View";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 58);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1292, 616);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Setting";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(tabs1);
            Controls.Add(divider2);
            Controls.Add(windowBar);
            Font = new Font("Microsoft YaHei UI", 12F);
            ForeColor = Color.Black;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            windowBar.ResumeLayout(false);
            tabs1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Button btn_mode;
        private AntdUI.Divider divider2;
        private AntdUI.WindowBar windowBar;
        private AntdUI.Tabs tabs1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private TabPage tabPage3;
        private Label label3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Panel panel2;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem selecToolStripMenuItem;
        private ToolStripMenuItem huyChonToolStripMenuItem;
        private AntdUI.Table table1;
        private AntdUI.Button button17;
        private AntdUI.Button button16;
        private Panel panel6;
        private AntdUI.Input input9;
        private AntdUI.Button button2;
        private Panel panel8;
        private AntdUI.Select select6;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}