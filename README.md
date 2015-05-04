# Xamarin-FreshDesk-iOS
Xamarin integration for freshdesk iOS

In order to use the SDK, you can take the .dll file from here: https://github.com/IdoTene/Xamarin-FreshDesk-iOS/blob/master/FreshDeskBinding.dll

In your AppDelegate, FinishedLaunching method, add this code:

            MobihelpConfig config = new MobihelpConfig("YourDomain.freshdesk.com", "appKey", "AppSecret");
            Mobihelp mobileHelp = new Mobihelp();
            mobileHelp.InitWithConfig(config);
            
Once you have decided to open the FreshDeskSupport window, call to

            Mobihelp.SharedInstance().PresentSupport(this);

Finally, add the resoures (.bundle) that exist in the SDK to your resources folder.
You can find the SDK here: https://s3.amazonaws.com/assets.mobihelp.freshpo.com/sdk/mobihelp_sdk_ios.zip
           
That's it!
