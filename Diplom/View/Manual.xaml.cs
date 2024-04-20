using Diplom.Core;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Diplom.View;
using System.Security.Cryptography;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для Manual.xaml
    /// </summary>
    public partial class Manual : Page
    {
        public Manual()
        {
            InitializeComponent();
            FrameNavigate.FrameCore = PageFrame;
            PageFrame.Navigate(new Home1());
        }

        private void OpenMenu()
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = 150; 
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));

            menuBorder.BeginAnimation(Border.WidthProperty, animation);
        }

        private void CloseMenu()
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));

            menuBorder.BeginAnimation(Border.WidthProperty, animation);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Home());
        }






        private void ToggleMenu_Click_1(object sender, RoutedEventArgs e)
        {
            if (menuBorder.Width == 0)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Account());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Tests());
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Tests());
        }

        private void PackIcon_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Home1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Glossary());
        }

        private void PackIcon_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Glossary());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Lectures());
        }

        private void PackIcon_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Lectures());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Home1());
        }

        private void PackIcon_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Admin());
        }

        private void PackIcon_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameCore.Navigate(new Account());
        }
    }
}
