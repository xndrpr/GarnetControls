# GarnetControls 

# Controls
* Window - GarnetControls.Controls.Window
* Button - GarnetControls.Controls.Button
* NumericUpDown - GarnetControls.Controls.NumericUpDown
* SideBarItem - GarnetControls.Controls.SideBarItem

# Get started
## 1 - Add the reference to the controls
```c#
<Window xmlns:gc="clr-namespace:GarnetControls.Controls;assembly=GarnetControls">

</Window>
```
## 2 - Use the controls

#### Window
```xml
<gc:Window></gc:Window>
```
##### Show/Hide title
```c#
<gc:Window xmlns:gc="clr-namespace:GarnetControls.Controls;assembly=GarnetControls" ShowTitle="True/False">
</gc:Window>
```


```c#
namespace YourNamespace
{
    public partial class MainWindow : GarnetControls.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

```

#### Button

```xml
<gc:Button>Button</gc:Button>
```

#### NumericUpDown
This is a simple numeric up down control

```xml
<gc:NumericUpDown MinValue="0" MaxValue="100"/>
```

#### SideBarItem
