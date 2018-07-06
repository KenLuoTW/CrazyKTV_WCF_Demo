using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrazyKTV_WCF_Demo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool WCFlive = CrazyKTVWCF.checkWCF();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           


        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.QuerySong(null, null, null, "Song_SingerType=3", null, 10, null);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.QuerySong(null, null, null, "Song_Singer='張學友'", null, 10, null);
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.QuerySong(null, null, null, "Song_SongName like '*愛情*'", null, 10, null);
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.QuerySinger("Singer_Type=1", 0, 10, "Singer_Name");
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.DoCrazyKTV_Action(null, "Cut");
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (WCFlive)
            {
                textbox.Text = CrazyKTVWCF.DoCrazyKTV_Control(null, "Mute");
            }
        }
    }
}
