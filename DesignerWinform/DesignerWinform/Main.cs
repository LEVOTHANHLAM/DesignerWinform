using AntdUI;

namespace DesignerWinform
{
    public partial class Main : AntdUI.Window
    {
        public class TestClass : AntdUI.NotifyProperty
        {
            public TestClass(int? i, string? key, string? name, int? age, string? address)
            {
                _key = key;
                _btns = new AntdUI.CellLink[] {
                   // new AntdUI.CellButton("edit","Edit",AntdUI.TTypeMini.Primary),
                    new AntdUI.CellButton("delete","Delete",AntdUI.TTypeMini.Error)
                    };
                //if (i == 1) _online = new AntdUI.CellBadge(AntdUI.TState.Success, "ÔÚÏß");
                //else if (i == 2) _online = new AntdUI.CellBadge(AntdUI.TState.Processing, "´¦ÖÃ");
                //else if (i == 3) _online = new AntdUI.CellBadge(AntdUI.TState.Error, "ÀëÏß");
                //else if (i == 4) _online = new AntdUI.CellBadge(AntdUI.TState.Warn, "ÀëÏß");
                //else _online = new AntdUI.CellBadge(AntdUI.TState.Default, "³£¹æ");
                _online = new AntdUI.CellBadge(AntdUI.TState.Default, "Online");
                _name = name;
                _age = age;
                _address = address;
                //if (i == 1)
                //{
                //    _imgs = new AntdUI.CellImage[] {
                //        new AntdUI.CellImage(Properties.Resources.img1){ BorderWidth=4,BorderColor=Color.BlueViolet},
                //        new AntdUI.CellImage(Properties.Resources.bg1)
                //    };
                //}
                //if (i == 2)
                //{
                //    _btns = new AntdUI.CellLink[] {
                //    new AntdUI.CellButton("edit","Edit",AntdUI.TTypeMini.Primary) {  Ghost = true,BorderWidth=1 },
                //    new AntdUI.CellButton("delete","Delete",AntdUI.TTypeMini.Error) {  Ghost = true ,BorderWidth=1}
                //    };
                //}
                //else if (i == 3)
                //{
                //    _btns = new AntdUI.CellLink[] {
                //   // new AntdUI.CellButton("edit","Edit",AntdUI.TTypeMini.Primary),
                //    new AntdUI.CellButton("delete","Delete",AntdUI.TTypeMini.Error)
                //    };
                //}
                //else
                //{
                //    _btns = new AntdUI.CellLink[] {
                //    new AntdUI.CellLink("delete","Delete")
                //};
                //}
            }

            bool _check = false;
            public bool check
            {
                get => _check;
                set
                {
                    if (_check == value) return;
                    _check = value;
                    OnPropertyChanged("check");
                }
            }

            string? _key;
            public string? key
            {
                get => _key;
                set
                {
                    if (_key == value) return;
                    _key = value;
                    OnPropertyChanged("key");
                }
            }

            string? _name;
            public string? name
            {
                get => _name;
                set
                {
                    if (_name == value) return;
                    _name = value;
                    OnPropertyChanged("name");
                }
            }

            AntdUI.CellBadge? _online;
            public AntdUI.CellBadge? online
            {
                get => _online;
                set
                {
                    _online = value;
                    OnPropertyChanged("online");
                }
            }

            int? _age;
            public int? age
            {
                get => _age;
                set
                {
                    if (_age == value) return;
                    _age = value;
                    OnPropertyChanged("age");
                }
            }

            string _address;
            public string address
            {
                get => _address;
                set
                {
                    if (_address == value) return;
                    _address = value;
                    OnPropertyChanged("address");
                }
            }

            AntdUI.CellTag[]? _tag;
            public AntdUI.CellTag[]? tag
            {
                get => _tag;
                set
                {
                    _tag = value;
                    OnPropertyChanged("tag");
                }
            }

            AntdUI.CellImage[]? _imgs;
            public AntdUI.CellImage[]? imgs
            {
                get => _imgs;
                set
                {
                    _imgs = value;
                    OnPropertyChanged("imgs");
                }
            }

            AntdUI.CellLink[]? _btns;
            public AntdUI.CellLink[]? btns
            {
                get => _btns;
                set
                {
                    _btns = value;
                    OnPropertyChanged("btns");
                }
            }
        }

        public class TestClass2 : AntdUI.NotifyProperty
        {
            public TestClass2(int i, string name, int age, string address)
            {
                _name = name;
                _age = age;
                _address = address;
                if (i % 2 == 0) _tag = new AntdUI.CellTag("YES" + i, AntdUI.TTypeMini.Success);
                else _tag = new AntdUI.CellTag("NO" + i, AntdUI.TTypeMini.Error);
            }

            string _name;
            public string name
            {
                get => _name;
                set
                {
                    if (_name == value) return;
                    _name = value;
                    OnPropertyChanged("name");
                }
            }

            int _age;
            public int age
            {
                get => _age;
                set
                {
                    if (_age == value) return;
                    _age = value;
                    OnPropertyChanged("age");
                }
            }

            string _address;
            public string address
            {
                get => _address;
                set
                {
                    if (_address == value) return;
                    _address = value;
                    OnPropertyChanged("address");
                }
            }

            AntdUI.CellTag? _tag;
            public AntdUI.CellTag? tag
            {
                get => _tag;
                set
                {
                    _tag = value;
                    OnPropertyChanged("tag");
                }
            }
        }
        public Main()
        {
            InitializeComponent();
            // colorPicker1.ValueChanged += ColorPicker1_ValueChanged;
            BackColor = Color.FromArgb(215, 255, 254);
            ForeColor = Color.Black;
            table1.Columns = new AntdUI.Column[] {
                new AntdUI.ColumnCheck("check"){ Fixed=false},
                new AntdUI.Column("name","name",AntdUI.ColumnAlign.Center){ Fixed=true},
                new AntdUI.Column("online","online",AntdUI.ColumnAlign.Center),
                new AntdUI.Column("age","age",AntdUI.ColumnAlign.Center),
                new AntdUI.Column("address","address",AntdUI.ColumnAlign.Center),
                new AntdUI.Column("tag","Tag",AntdUI.ColumnAlign.Center),
                new AntdUI.Column("imgs","imgs",AntdUI.ColumnAlign.Center),
                new AntdUI.Column("btns","btns",AntdUI.ColumnAlign.Center){ Fixed=true},
            };
            // Ìí¼Ó±í
            var list = new List<TestClass>(10) {
                new TestClass(null, null, null,null,null),
            //    new TestClass(2,"2","ºLam Le 2",43,"Quang ngai 2") {
            //        tag=new AntdUI.CellTag[]{ new AntdUI.CellTag("Live", AntdUI.TTypeMini.Success)}
            //    },
            };// Ìí¼ÓÊý¾Ý
              //for (int i = 3; i < 5; i++) list.Add(new TestClass(i, i.ToString(), $"Lam Le {i.ToString()} sàdsffffffffffffffffffffffsdfsđhhjkhjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjffffffffffffffffffffffffffffffffffffffffffffffffffff", 100, $"Quang ngai {i.ToString()}"));
              //var list = new List<TestClass>(1);
              // table1.DataSource = list;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DraggableMouseDown();
            base.OnMouseDown(e);
        }

        private void table1_CellButtonClick(object sender, AntdUI.CellLink btn, MouseEventArgs args, object record, int rowIndex, int columnIndex)
        {
            try
            {
                if (record is TestClass data)
                {
                    var s = new AntdUI.Modal.Config(this, "Xóa hay không", new AntdUI.Modal.TextLine[] {
                new AntdUI.Modal.TextLine(data.name,AntdUI.Style.Db.Primary),
                new AntdUI.Modal.TextLine(data.address,6,AntdUI.Style.Db.TextSecondary)
            }, AntdUI.TType.Error)
                    {
                        CancelText = "No",
                        OkType = AntdUI.TTypeMini.Error,
                        OkText = "Xóa"

                    };
                    if(AntdUI.Modal.open(s) == DialogResult.OK)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        private void Btn(object? sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is IList tag)
            {
                Control? control_add = null;
                //switch (tag.id)
                //{
                //    case "Button":
                //        control_add = new Controls.Button();
                //        break;
                //    case "Avatar":
                //        control_add = new Controls.Avatar();
                //        break;
                //    case "Carousel":
                //        control_add = new Controls.Carousel();
                //        break;
                //    case "Badge":
                //        control_add = new Controls.Badge();
                //        break;
                //    case "Checkbox":
                //        control_add = new Controls.Checkbox();
                //        break;
                //    case "Radio":
                //        control_add = new Controls.Radio();
                //        break;
                //    case "Input":
                //        control_add = new Controls.Input();
                //        break;
                //    case "Select":
                //        control_add = new Controls.Select();
                //        break;
                //    case "Panel":
                //        control_add = new Controls.Panel();
                //        break;
                //    case "Progress":
                //        control_add = new Controls.Progress();
                //        break;
                //    case "Tooltip":
                //        control_add = new Controls.Tooltip();
                //        break;
                //    case "Divider":
                //        control_add = new Controls.Divider();
                //        break;
                //    case "Slider":
                //        control_add = new Controls.Slider();
                //        break;
                //    case "Tabs":
                //        control_add = new Controls.Tabs();
                //        break;
                //    case "Switch":
                //        control_add = new Controls.Switch();
                //        break;
                //    case "Pagination":
                //        control_add = new Controls.Pagination();
                //        break;
                //    case "Alert":
                //        control_add = new Controls.Alert();
                //        break;
                //    case "Message":
                //        control_add = new Controls.Message();
                //        break;
                //    case "Notification":
                //        control_add = new Controls.Notification();
                //        break;
                //    case "Menu":
                //        control_add = new Controls.Menu();
                //        break;
                //    case "Segmented":
                //        control_add = new Controls.Segmented();
                //        break;
                //    case "Modal":
                //        control_add = new Controls.Modal();
                //        break;
                //    case "DatePicker":
                //        control_add = new Controls.DatePicker();
                //        break;
                //    case "TimePicker":
                //        control_add = new Controls.TimePicker();
                //        break;
                //    case "Dropdown":
                //        control_add = new Controls.Dropdown();
                //        break;
                //    case "Tree":
                //        control_add = new Controls.Tree();
                //        break;
                //    case "Popover":
                //        control_add = new Controls.Popover();
                //        break;
                //    case "Timeline":
                //        control_add = new Controls.Timeline();
                //        break;
                //    case "Steps":
                //        control_add = new Controls.Steps();
                //        break;
                //    case "ColorPicker":
                //        control_add = new Controls.ColorPicker();
                //        break;
                //    case "InputNumber":
                //        control_add = new Controls.InputNumber();
                //        break;
                //    case "Tag":
                //        control_add = new Controls.Tag();
                //        break;
                //    case "Drawer":
                //        control_add = new Controls.Drawer();
                //        break;
                //    case "FloatButton":
                //        FloatButton?.Close();
                //        FloatButton = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, new AntdUI.FloatButton.ConfigBtn[] {
                //            new AntdUI.FloatButton.ConfigBtn("id1", Properties.Resources.icon_search, true){
                //                Tooltip = "搜索一下",
                //                Type= AntdUI.TTypeMini.Primary
                //            },
                //            new AntdUI.FloatButton.ConfigBtn("id2", Properties.Resources.img1){
                //                Badge = " ",
                //                Tooltip = "笑死人",
                //            },
                //            new AntdUI.FloatButton.ConfigBtn("id3",Properties.Resources.icon_like, true){
                //                Badge = "9",
                //                Tooltip = "救救我"
                //            },
                //            new AntdUI.FloatButton.ConfigBtn("id4", Properties.Resources.icon_poweroff, true){
                //                Badge = "99+",
                //                Tooltip = "没救了",
                //                Shape = AntdUI.TShape.Default,
                //                Type= AntdUI.TTypeMini.Primary
                //            }
                //        }, btn =>
                //        {
                //            AntdUI.Message.info(this, "点击了：" + btn.Name, Font);
                //        }));
                //        break;
                //    case "Rate":
                //        control_add = new Controls.Rate();
                //        break;
                //    case "Table":
                //        control_add = new Controls.Table();
                //        break;
                //}
                //if (control_add != null)
                //{
                //    btn_back.Tag = control_add;
                //    BeginInvoke(() =>
                //    {
                //        flowPanel.Visible = false;
                //        foreach (AntdUI.Panel c in flowPanel.Controls)
                //        {
                //            c.SetMouseHover(false);
                //        }
                //        control_add.Dock = DockStyle.Fill;
                //        AutoDpi(control_add);
                //        Controls.Add(control_add);
                //        control_add.BringToFront();
                //        windowBar.UseLeft = btn_back.Width;
                //        btn_back.Visible = true;
                //    });
                //}
            }
        }
        Form? FloatButton = null;

        private void btn_back_Click(object sender, EventArgs e)
        {
            //BeginInvoke(() =>
            //{
            //    if (btn_back.Tag is Control control)
            //    {
            //        control.Dispose();
            //        Controls.Remove(control);
            //    }
            //    btn_back.Visible = false;
            // windowBar.UseLeft = 0;
            //  flowPanel.Visible = true;
            //});
        }

        private void btn_mode_Click(object? sender, EventArgs e)
        {
            AntdUI.Config.IsDark = !AntdUI.Config.IsDark;
            Dark = AntdUI.Config.IsDark;
            if (Dark)
            {
                BackColor = Color.FromArgb(72, 85, 99);
                ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromArgb(215, 255, 254);
                ForeColor = Color.Black;
            }
            //foreach (AntdUI.Panel item in flowPanel.Controls)
            //{
            //    foreach (Control control in item.Controls)
            //    {
            //        if (control is PictureBox pic && pic.Tag is IList tag)
            //        {
            //pic.Image = Dark ? tag.imgs[1] : tag.imgs[0];
            //        }
            //    }
            //}
            OnSizeChanged(e);
        }

        private void ColorPicker1_ValueChanged(object sender, Color value)
        {
            //  AntdUI.Style.Db.SetPrimary(value);
            //  Refresh();
        }

        #region 加载列表

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            windowBar.Loading = false;
            //  Task.Run(LoadList);
        }

        void LoadList()
        {
            //var dpi = AntdUI.Config.Dpi;

            //var dir = new IList[]
            //{
            //    //通用
            //    new IList("Button","按钮", res_light.Button, res_dark.Button),
            //    new IList("FloatButton","悬浮按钮",res_light.FloatButton, res_dark.FloatButton),

            //    //布局
            //    new IList("Divider","分割线", res_light.Divider, res_dark.Divider),

            //    //导航
            //    new IList("Dropdown","下拉菜单", res_light.Dropdown, res_dark.Dropdown),
            //    new IList("Menu","导航菜单", res_light.Menu, res_dark.Menu),
            //    new IList("Pagination","分页",res_light.Pagination, res_dark.Pagination),
            //    new IList("Steps","步骤条",res_light.Steps, res_dark.Steps),

            //    //数据录入
            //    new IList("Checkbox","多选框", res_light.Checkbox, res_dark.Checkbox),
            //    new IList("ColorPicker","颜色选择器", res_light.ColorPicker, res_dark.ColorPicker),
            //    new IList("DatePicker","日期选择框", res_light.DatePicker, res_dark.DatePicker),
            //    new IList("Input","输入框", res_light.Input, res_dark.Input),
            //    new IList("InputNumber","数字输入框", res_light.InputNumber, res_dark.InputNumber),
            //    new IList("Radio","单选框", res_light.Radio, res_dark.Radio),
            //    new IList("Rate","评分", res_light.Rate, res_dark.Rate),
            //    new IList("Select","选择器", res_light.Select, res_dark.Select),
            //    new IList("Slider","滑动输入条",res_light.Slider, res_dark.Slider),
            //    new IList("Switch","开关",res_light.Switch, res_dark.Switch),
            //    new IList("TimePicker","时间选择框",res_light.TimePicker, res_dark.TimePicker),

            //    //数据展示
            //    new IList("Avatar","头像", res_light.Avatar, res_dark.Avatar),
            //    new IList("Badge","徽标数",res_light.Badge, res_dark.Badge),
            //    new IList("Panel","面板", res_light.Panel, res_dark.Panel),
            //    new IList("Carousel","走马灯",res_light.Carousel, res_dark.Carousel),
            //    new IList("Popover","气泡卡片",res_light.Popover, res_dark.Popover),
            //    new IList("Segmented","分段控制器",res_light.Segmented, res_dark.Segmented),
            //    new IList("Table","表格",res_light.Table, res_dark.Table),
            //    new IList("Tabs","标签页",res_light.Tabs, res_dark.Tabs),
            //    new IList("Tag","标签",res_light.Tag, res_dark.Tag),
            //    new IList("Timeline","时间轴",res_light.Timeline, res_dark.Timeline),
            //    new IList("Tooltip","文字提示",res_light.Tooltip, res_dark.Tooltip),
            //    new IList("Tree","树形控件",res_light.Tree, res_dark.Tree),

            //    //反馈
            //    new IList("Alert","警告提示",res_light.Alert, res_dark.Alert),
            //    new IList("Drawer","抽屉",res_light.Drawer, res_dark.Drawer),
            //    new IList("Message","全局提示",res_light.Message, res_dark.Message),
            //    new IList("Modal","对话框",res_light.Modal, res_dark.Modal),
            //    new IList("Notification","通知提醒框",res_light.Notification, res_dark.Notification),
            //    new IList("Progress","进度条",res_light.Progress, res_dark.Progress),
            //};

            //var panel_size = new Size((int)(258 * dpi), (int)(244 * dpi));
            //int title_height = (int)(44 * dpi), size = (int)(10 * dpi), size2 = size * 2;

            //BeginInvoke(() =>
            //{
            //    flowPanel.PauseLayout = true;
            //    flowPanel.Controls.Clear();
            //    foreach (var item in dir)
            //    {
            //        var panel = new AntdUI.Panel
            //        {
            //            BorderWidth = 1F,
            //            Location = new Point(0, 0),
            //            Margin = new Padding(0),
            //            Shadow = 20,
            //            Size = panel_size,
            //            Tag = item
            //        };
            //        var pic = new PictureBox
            //        {
            //            BackColor = Color.Transparent,
            //            Dock = DockStyle.Fill,
            //            Image = Dark ? item.imgs[1] : item.imgs[0],
            //            SizeMode = PictureBoxSizeMode.CenterImage,
            //            Tag = item
            //        };

            //        var divider = new AntdUI.Divider
            //        {
            //            BackColor = Color.Transparent,
            //            Dock = DockStyle.Top,
            //            Margin = new Padding(size),
            //            Size = new Size(0, 1),
            //            Tag = item
            //        };
            //        var label = new Label
            //        {
            //            BackColor = Color.Transparent,
            //            Dock = DockStyle.Top,
            //            Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point),
            //            Padding = new Padding(size2, 0, 0, 0),
            //            Size = new Size(0, title_height),
            //            Text = item.id + " " + item.key,
            //            TextAlign = ContentAlignment.MiddleLeft,
            //            Tag = item
            //        };
            //        panel.Controls.Add(pic);
            //        panel.Controls.Add(divider);
            //        panel.Controls.Add(label);
            //        pic.Click += Btn;
            //        label.Click += Btn;
            //        flowPanel.Controls.Add(panel);
            //    }
            //    flowPanel.PauseLayout = false;
            //    windowBar.Loading = false;
            //});
        }

        class IList
        {
            public IList(string _id, string _key, string _img_light, string _img_dark)
            {
                id = _id;
                key = _key;
                imgs = new Image[] { AntdUI.SvgExtend.SvgToBmp(_img_light), AntdUI.SvgExtend.SvgToBmp(_img_dark) };
            }
            public string id { get; set; }
            public string key { get; set; }
            public Image[] imgs { get; set; }
        }

        #endregion

        private void colorPicker1_ValueChanged_1(object sender, Color value)
        {

        }
    }
}