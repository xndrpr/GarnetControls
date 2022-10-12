using System.Windows;

namespace GarnetControls.Controls
{
    internal class TitleButton : Button
    {
        static TitleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleButton), new FrameworkPropertyMetadata(typeof(TitleButton)));
        }
    }
}
