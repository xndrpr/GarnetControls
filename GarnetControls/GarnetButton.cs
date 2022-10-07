using System.Windows;

namespace GarnetControls
{
    public class GarnetButton : System.Windows.Controls.Button
    {
        static GarnetButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GarnetButton), new FrameworkPropertyMetadata(typeof(GarnetButton)));
        }
    }
}
