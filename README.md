# Xamarin-FreshDesk-iOS
Xamarin integration for freshdesk iOS

In order to use the SDK, you can take the .dll file from here: https://github.com/IdoTene/Xamarin-FreshDesk-iOS/blob/master/FreshDeskBinding.dll

In your AppDelegate, FinishedLaunching method, add this code:

            MobihelpConfig config = new MobihelpConfig("YourDomain.freshdesk.com", "appKey", "AppSecret");
            Mobihelp mobileHelp = new Mobihelp();
            mobileHelp.InitWithConfig(config);
            
Once you have decided to open the FreshDeskSupport window, call to

            Mobihelp.SharedInstance().PresentSupport(this);

           
That's it!
