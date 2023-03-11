using System;
using System.Windows;
using System.Windows.Media;

namespace GarnetControls.Controls
{
    public class SelectableListBoxItem : System.Windows.Controls.ListBoxItem
    {
        static SelectableListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SelectableListBoxItem), new FrameworkPropertyMetadata(typeof(SelectableListBoxItem)));
        }



        public string Target
        {
            get { return (string)GetValue(TargetProperty); }
            set { SetValue(TargetProperty, value); }
        }

        public static readonly DependencyProperty TargetProperty = DependencyProperty.Register("Target", typeof(string), typeof(SelectableListBoxItem), new PropertyMetadata(null));



        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(Geometry), typeof(SelectableListBoxItem), new PropertyMetadata(null));


        public CornerRadius Radius
        {
            get { return (CornerRadius)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        public static readonly DependencyProperty RadiusProperty = DependencyProperty.Register("Radius", typeof(CornerRadius), typeof(ListBoxItem), null);



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SelectableListBoxItem), new PropertyMetadata("Text"));

        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        public static readonly DependencyProperty ShowIconProperty = DependencyProperty.Register("ShowIcon", typeof(bool), typeof(SelectableListBoxItem), new PropertyMetadata(true));




        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }
            set { SetValue(IconVisibilityProperty, value); }
        }

        public static readonly DependencyProperty IconVisibilityProperty = DependencyProperty.Register("IconVisibility", typeof(Visibility), typeof(SelectableListBoxItem), new PropertyMetadata(Visibility.Visible));


        public HorizontalAlignment ContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(ContentAlignmentProperty); }
            set { SetValue(ContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ContentAlignmentProperty = DependencyProperty.Register("ContentAlignment", typeof(HorizontalAlignment), typeof(SelectableListBoxItem), new PropertyMetadata(HorizontalAlignment.Center));
    }
}
