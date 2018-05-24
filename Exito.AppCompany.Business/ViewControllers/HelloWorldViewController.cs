
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Exito.AppCompany.Business.ViewControllers
{
    public partial class HelloWorldViewController : UIViewController
    {
        public HelloWorldViewController(IntPtr handle) : base(handle)
        {
        }
        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
        #endregion
    }
}