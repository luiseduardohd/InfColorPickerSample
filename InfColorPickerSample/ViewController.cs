using Foundation;
using InfColorPicker;
using System;
using UIKit;

namespace InfColorPickerSample
{
    public partial class ViewController : UIViewController
    { 
        ColorSelectedDelegate selector;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ChangeColorButton.TouchUpInside += HandleTouchUpInsideWithStrongDelegate;
            selector = new ColorSelectedDelegate(this);
        }
        private void HandleTouchUpInsideWithStrongDelegate(object sender, EventArgs e)
        {
            InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
            picker.Delegate = selector;
            picker.PresentModallyOverViewController(this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}