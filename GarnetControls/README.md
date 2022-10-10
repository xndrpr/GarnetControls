# Markdown File

# Controls
* Window - GarnetControls.Controls.Window
* Button - GarnetControls.Controls.Button
* TitleButton - GarnetControls.Controls.TitleButton
* NumericUpDown - GarnetControls.Controls.NumericUpDown


# Get started
## 1 - Add the reference to the controls
```c#
<Window xmlns:gc="clr-namespace:GarnetControls.Controls;assembly=GarnetControls">

</Window>
```
## 2 - Use the controls

#### Window
<img src="https://i.postimg.cc/L54PXtkN/UGCleaner-EKCsom3pj-F.png"></img>
```xml
<gc:Window></gc:Window>
```
##### Show/Hide title
```c#
<gc:Window xmlns:gc="clr-namespace:GarnetControls.Controls;assembly=GarnetControls" ShowTitle="True/False">
</gc:Window>
```

<img src="https://i.postimg.cc/d0MTdPm7/UGCleaner-u-SRpoh-OTDt.png"></img>

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
<img src="https://i.postimg.cc/0NpK0WcV/UGCleaner-rd5-Of1-Lk-Ft.png"/>

```xml
<gc:Button>Button</gc:Button>
```

#### TitleButton
This is a button like in the title.
```xml
<gc:TitleButton>Title Button</gc:Button>
```
#### NumericUpDown
This is a button like in the title.

```xml
<gc:NumericUpDown MinValue="0" MaxValue="100"/>
```