using System;
using InfColorPicker;
using UIKit;

namespace InfColorPickerSample
{
    public class ColorSelectedDelegate : InfColorPickerControllerDelegate
    {
        readonly UIViewController parent;

        public ColorSelectedDelegate(UIViewController parent)
        {
            this.parent = parent;
        }

        public override void ColorPickerControllerDidFinish(InfColorPickerController controller)
        {
            parent.View.BackgroundColor = controller.ResultColor;
            parent.DismissViewController(false, null);
        }
    }
}
