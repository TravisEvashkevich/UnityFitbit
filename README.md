## Important
Please note I haven't done Fitbit programming since this was put up (over 6 years ago) and I don't know how to get things running with Fitbit and their current API. 
As much as I'd love to help people get up and running I don't have the time to investigate it myself. This Repo might not be useful anymore but I'm leaving it up in case it does hold a nugget of truth.

# UnityFitbit
Classes to help with getting data from Fitbit. 
Check out the Example Project (Example Project/Fitbit Example Project/Assets -> Example Scene)

***-----IMPORTANT! ----***

***You may have to add the FITBITAPI.cs script to the "Fitbit Caller" Object for the example to work. ***

You can watch a videon on how to get up and running below

https://youtu.be/Nec-7eNgQNs

If you're interested in how to use the class WITH Android This should help :)
http://technicalartistry.blogspot.ca/2016/01/fitbit-unity-oauth-2-and-native.html

An example of how you would use this is:
- Put the scripts in your Unity Assets/Scripts folder.
- Put the Newtonsoft.Json.dll in your Assets/Plugins folder
- Get your ClientID and ClientSecret setup in the file (you're supposed to not put it in this file but it makes it easier to get it up and running. Please handle this on your own)
- Put your CallBackURL in the file (_callbackURL)
  - If doing Android, fill in your Android custom scheme in the CustomAndroidScheme
- Include it in whatever file you are wanting to use to get the Fitbit data.
- Call Methods from FitbitAPI to start getting Data :D
(start with LoginToFitbit(); After that you can start using GetSteps etc.)

* If you're going to use it with Android you'll really want to check out the blogpost above that shows you how to make the extra piece that you need to be able to get the callback back into your app. Without it, you won't get far. 
* If you're just using it on Desktop then it's fine, you should be able to just use the classes with no problem. The only caveat is that there is no way to grab the return code directly from the browser so your user will have to copy paste it manually.
