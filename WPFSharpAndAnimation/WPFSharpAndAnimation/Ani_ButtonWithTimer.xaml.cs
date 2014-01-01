using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFSharpAndAnimation
{
    /// <summary>
    /// Ani_ButtonWithTimer.xaml 的交互逻辑
    /// </summary>
    //使用Timer实现动画效果，下一例将使用WPF内置类来实现动画效果
    public partial class Ani_ButtonWithTimer : Window
    {
        const double initfontsize = 12;
        const double maxfontsize = 48;
        Button btn;

        public Ani_ButtonWithTimer()
        {
            InitializeComponent();
            Title = "EnlargeButtonWithTimer";

            btn = new Button();
            btn.Content = "Expanding Button";
            btn.FontSize = initfontsize;
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.Click += btn_Click;
            Content = btn;
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer tmr = new DispatcherTimer();
            tmr.Interval = TimeSpan.FromSeconds(0.1);
            tmr.Tick += tmr_Tick;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            btn.FontSize += 2;
            if (btn.FontSize >= maxfontsize)
            {
                btn.FontSize = initfontsize;
                (sender as DispatcherTimer).Stop();
            }
        }
    }
}
