using System.Windows;
using System.Windows.Controls;

namespace GarnetControls.Controls
{
    public class NumericUpDown : System.Windows.Controls.Control
    {
        private TextBlock countText;
        private TitleButton upBtn;
        private TitleButton downBtn;

        #region Properties

        public static DependencyProperty MinValueProperty = DependencyProperty.Register("MinValue", typeof(int), typeof(NumericUpDown), new PropertyMetadata(0));

        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public static DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(int), typeof(NumericUpDown), new PropertyMetadata(100));

        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }


        #endregion

        static NumericUpDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumericUpDown), new FrameworkPropertyMetadata(typeof(NumericUpDown)));
        }

        public T GetRequiredTemplateChild<T>(string childName) where T : DependencyObject
        {
            return (T)GetTemplateChild(childName);
        }

        public override void OnApplyTemplate()
        {
            countText = GetRequiredTemplateChild<TextBlock>("count");
            upBtn = GetRequiredTemplateChild<TitleButton>("upBtn");
            downBtn = GetRequiredTemplateChild<TitleButton>("downBtn");

            if (upBtn != null)
            {
                upBtn.Click += UpBtn_Click;
            }
            if (downBtn != null)
            {
                downBtn.Click += DownBtn_Click;
            }
        }

        private void DownBtn_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(countText.Text);

            if (value > MinValue)
                countText.Text = (value - 1).ToString();
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(countText.Text);
            if (value < MaxValue)
                countText.Text = (value + 1).ToString();
        }
    }
}
