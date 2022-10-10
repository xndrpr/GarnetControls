using System.Windows;

namespace GarnetControls.Controls
{
    public class Avatar : System.Windows.Controls.Image
    {
        static Avatar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Avatar), new FrameworkPropertyMetadata(typeof(Avatar)));
        }
    }
}
