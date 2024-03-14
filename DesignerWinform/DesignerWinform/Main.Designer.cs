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
            panel6 = new Panel();
            input9 = new AntdUI.Input();
            button2 = new AntdUI.Button();
            button16 = new AntdUI.Button();
            button17 = new AntdUI.Button();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            input1 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            select1 = new AntdUI.Select();
            button4 = new AntdUI.Button();
            table2 = new AntdUI.Table();
            tabPage3 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            panel3 = new Panel();
            select2 = new AntdUI.Select();
            windowBar.SuspendLayout();
            tabs1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button17);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 5, 0);
            panel1.Size = new Size(1286, 40);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(input9);
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1031, 0);
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
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(table2);
            tabPage2.Location = new Point(4, 58);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1292, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 5, 0);
            panel4.Size = new Size(1286, 40);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(512, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(769, 40);
            panel5.TabIndex = 20;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox4.Image = Properties.Resources.icons8_minus_35;
            pictureBox4.Location = new Point(431, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(input1);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(519, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 40);
            panel7.TabIndex = 14;
            panel7.Text = "panel4";
            // 
            // input1
            // 
            input1.Dock = DockStyle.Fill;
            input1.JoinRight = true;
            input1.Location = new Point(0, 0);
            input1.Margins = 6;
            input1.Name = "input1";
            input1.PlaceholderText = "Search";
            input1.Size = new Size(200, 40);
            input1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Right;
            button1.ImageSvg = Properties.Resources.icon_search;
            button1.JoinLeft = true;
            button1.Location = new Point(200, 0);
            button1.Margins = 6;
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 1;
            button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox5.Image = Properties.Resources.icons8_add_35__1_;
            pictureBox5.Location = new Point(392, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox6.Image = Properties.Resources.icons8_transfer_35;
            pictureBox6.Location = new Point(472, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(select1);
            panel9.Location = new Point(136, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 40);
            panel9.TabIndex = 15;
            panel9.Text = "panel4";
            // 
            // select1
            // 
            select1.AllowClear = true;
            select1.Dock = DockStyle.Fill;
            select1.Items.AddRange(new object[] { "Lucy", "Tom", "AduSkin", "WangLi", "HUAWEI", "XIAOMI" });
            select1.JoinRight = true;
            select1.Location = new Point(0, 0);
            select1.Margins = 6;
            select1.Name = "select1";
            select1.PlaceholderText = "";
            select1.Size = new Size(250, 40);
            select1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(5, 0);
            button4.Name = "button4";
            button4.Size = new Size(146, 40);
            button4.TabIndex = 12;
            button4.Text = "Export";
            button4.Type = AntdUI.TTypeMini.Warn;
            // 
            // table2
            // 
            table2.Bordered = true;
            table2.ContextMenuStrip = contextMenuStrip1;
            table2.Dock = DockStyle.Fill;
            table2.Font = new Font("Microsoft YaHei UI", 11F);
            table2.Location = new Point(3, 3);
            table2.Name = "table2";
            table2.Size = new Size(1286, 610);
            table2.TabIndex = 2;
            table2.Text = "table2";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 58);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1292, 616);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Script";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 28);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(192, 68);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "View";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 28);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(192, 68);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Setting";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(select2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(781, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 40);
            panel3.TabIndex = 16;
            panel3.Text = "panel4";
            // 
            // select2
            // 
            select2.AllowClear = true;
            select2.Dock = DockStyle.Fill;
            select2.Items.AddRange(new object[] { "Lucy", "Tom", "AduSkin", "WangLi", "HUAWEI", "XIAOMI" });
            select2.JoinRight = true;
            select2.Location = new Point(0, 0);
            select2.Margins = 6;
            select2.Name = "select2";
            select2.PlaceholderText = "";
            select2.Size = new Size(250, 40);
            select2.TabIndex = 0;
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
            panel6.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private TabPage tabPage3;
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
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Panel panel7;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel9;
        private AntdUI.Select select1;
        private AntdUI.Button button4;
        private AntdUI.Table table2;
        private Panel panel6;
        private AntdUI.Input input9;
        private AntdUI.Button button2;
        private Panel panel3;
        private AntdUI.Select select2;
    }
}