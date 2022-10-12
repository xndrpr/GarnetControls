using System.Windows;

namespace GarnetControls.Controls
{
    internal class CloseButton : Button
    {

        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton), new FrameworkPropertyMetadata(typeof(CloseButton)));
        }
    }
}
