using System;

namespace DesignerWinform
{
    public partial class fLogin : AntdUI.Window
    {
        public fLogin()
        {
            InitializeComponent();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            DraggableMouseDown();
            base.OnMouseDown(e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            AntdUI.Button btn = (AntdUI.Button)sender;
            btn.Loading = true;
            btn.Enabled = false;
            Main main = new Main();
            main.Show();
            this.Hide();
            //int nnn = random.Next(0, 20);
            //if (nnn > 10)
            //{
            //    btn.Loading = true;
            //    btn.Enabled = false;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        btn.Loading = false;
            //        btn.Invoke(() =>
            //        {
            //            btn.Enabled = true;
            //        });
            //    });
            //}
            //else if (nnn > 5)
            //{
            //    btn.Loading = true;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        btn.Loading = false;
            //    });
            //}
            //else
            //{
            //    btn.Enabled = false;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        btn.Invoke(() =>
            //        {
            //            btn.Enabled = true;
            //        });
            //    });
            //}
        }
    }
}
