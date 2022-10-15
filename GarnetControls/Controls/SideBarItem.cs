using System;
using System.Windows;
using System.Windows.Media;

namespace GarnetControls.Controls
{
    public class SideBarItem : System.Windows.Controls.ListBoxItem
    {
        static SideBarItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SideBarItem), new FrameworkPropertyMetadata(typeof(SideBarItem)));
        }



        public Uri NavigationLink
        {
            get { return (Uri)GetValue(NavigationLinkProperty); }
            set { SetValue(NavigationLinkProperty, value); }
        }

        public static readonly DependencyProperty NavigationLinkProperty = DependencyProperty.Register("NavigationLink", typeof(Uri), typeof(SideBarItem), new PropertyMetadata(null));



        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(Geometry), typeof(SideBarItem), new PropertyMetadata(null));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SideBarItem), new PropertyMetadata("Text"));



        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(int), typeof(SideBarItem), new PropertyMetadata(0));
    }
}
