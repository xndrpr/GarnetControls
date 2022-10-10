using System.Windows;

namespace GarnetControls.Controls
{
    public class ColorPicker : System.Windows.Controls.Control
    {
        static ColorPicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPicker), new FrameworkPropertyMetadata(typeof(ColorPicker)));
        }
    }
}
