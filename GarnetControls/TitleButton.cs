using System.Windows;

namespace GarnetControls
{
    public class TitleButton : System.Windows.Controls.Button
    {
        static TitleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleButton), new FrameworkPropertyMetadata(typeof(TitleButton)));
        }
    }
}
