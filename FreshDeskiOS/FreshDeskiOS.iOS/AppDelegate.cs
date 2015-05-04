using CoreGraphics;
using Foundation;
using FreshDeskSDKIOS;
using UIKit;

namespace FreshDeskiOS.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.

    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            MobihelpConfig config = new MobihelpConfig("YourDomain.freshdesk.com", "appKey", "AppSecret");
            Mobihelp mobileHelp = new Mobihelp();
            mobileHelp.InitWithConfig(config);

            window = new UIWindow(UIScreen.MainScreen.Bounds);

            var controller = new UIViewController();
            
            var supportButton = new UIButton(UIButtonType.RoundedRect);
            supportButton.Frame = new CGRect(10,20,200, 30);
            supportButton.SetTitle("ClickToShowSupport", UIControlState.Normal);
            supportButton.TouchDown += (sender, args) =>
            {
                Mobihelp.SharedInstance().PresentSupport(controller);
            };

            controller.View.AddSubview(supportButton);
            
            controller.View.BackgroundColor = UIColor.White;

            window.RootViewController = controller;

            // make the window visible
            window.MakeKeyAndVisible();

            return true;
        }
    }
}
