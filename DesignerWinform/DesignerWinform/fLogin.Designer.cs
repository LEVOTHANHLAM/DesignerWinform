using static AntdUI.Modal;

namespace DesignerWinform
{
    partial class fLogin
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
            AntdUI.CarouselItem carouselItem13 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem14 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem15 = new AntdUI.CarouselItem();
            panel1 = new Panel();
            carousel1 = new AntdUI.Carousel();
            alert12 = new AntdUI.Alert();
            input4 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            button17 = new AntdUI.Button();
            label4 = new Label();
            label1 = new Label();
            avatar4 = new AntdUI.Avatar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(carousel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 466);
            panel1.TabIndex = 0;
            // 
            // carousel1
            // 
            carousel1.AccessibleRole = AccessibleRole.None;
            carousel1.Autoplay = true;
            carousel1.BackColor = Color.Transparent;
            carousel1.Dock = DockStyle.Fill;
            carousel1.DotPosition = AntdUI.TAlignMini.Bottom;
            carouselItem13.Img = Properties.Resources.bg1;
            carouselItem14.Img = Properties.Resources.bg7;
            carouselItem15.Img = Properties.Resources.bg2;
            carousel1.Image.AddRange(new AntdUI.CarouselItem[] { carouselItem13, carouselItem14, carouselItem15 });
            carousel1.Location = new Point(0, 0);
            carousel1.Name = "carousel1";
            carousel1.SelectIndex = 2;
            carousel1.Size = new Size(335, 466);
            carousel1.TabIndex = 5;
            // 
            // alert12
            // 
            alert12.BackColor = Color.FromArgb(217, 252, 252);
            alert12.Dock = DockStyle.Top;
            alert12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alert12.ForeColor = Color.Black;
            alert12.Location = new Point(335, 0);
            alert12.Loop = true;
            alert12.Name = "alert12";
            alert12.Radius = 0;
            alert12.Size = new Size(511, 40);
            alert12.TabIndex = 8;
            alert12.Text = "Chào Mừng Bạn Đã Đến Với Chúng Tôi!         ";
            // 
            // input4
            // 
            input4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input4.Location = new Point(420, 219);
            input4.Name = "input4";
            input4.PasswordChar = '*';
            input4.PlaceholderText = "Password";
            input4.Round = true;
            input4.Size = new Size(348, 44);
            input4.TabIndex = 10;
            // 
            // input3
            // 
            input3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            input3.Location = new Point(420, 169);
            input3.Name = "input3";
            input3.PlaceholderText = "Username";
            input3.Round = true;
            input3.Size = new Size(348, 44);
            input3.TabIndex = 9;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(502, 295);
            button17.Name = "button17";
            button17.Size = new Size(189, 48);
            button17.TabIndex = 11;
            button17.Text = "Login";
            button17.Type = AntdUI.TTypeMini.Primary;
            button17.Click += button17_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 413);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Support";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 442);
            label1.Name = "label1";
            label1.Size = new Size(328, 15);
            label1.TabIndex = 13;
            label1.Text = "Liên Hệ : https://www.youtube.com/watch?v=ON_jkM0ZB0E";
            // 
            // avatar4
            // 
            avatar4.Image = Properties.Resources.img1;
            avatar4.Location = new Point(562, 77);
            avatar4.Name = "avatar4";
            avatar4.Round = true;
            avatar4.Size = new Size(70, 70);
            avatar4.TabIndex = 14;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(217, 252, 252);
            ClientSize = new Size(846, 466);
            Controls.Add(avatar4);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button17);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(alert12);
            Controls.Add(panel1);
            Cursor = Cursors.SizeAll;
            ForeColor = SystemColors.ActiveCaptionText;
            MaximumSize = new Size(846, 466);
            MinimumSize = new Size(846, 466);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private AntdUI.Carousel carousel1;
        private AntdUI.Alert alert12;
        private AntdUI.Input input4;
        private AntdUI.Input input3;
        private AntdUI.Button button17;
        private Label label4;
        private Label label1;
        private AntdUI.Avatar avatar4;
    }
}
