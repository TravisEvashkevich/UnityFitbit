# UnityFitbit
Class to help with Fitbit calls in Unity
This class will help with the OAuth2 part of getting data from Fitbit in Unity. 

If you're interested in how to use the class WITH Android This should help :)
http://technicalartistry.blogspot.ca/2016/01/fitbit-unity-oauth-2-and-native.html

An example of how you would use this is:
- Put the scripts in your Unity scripts folder.
-Get your ClientID and ClientSecret setup in the file (you're supposed to not put it in this file but it makes it easier to get it up and running. Please handle this on your own)
- Put your CallBackURL in the file (_callbackURL)
  - If doing Android, fill in your Android custom scheme in the CustomAndroidScheme
- Include it in whatever file you are wanting to use to get the Fitbit data.
- Call Methods from FitbitAPI to start getting Data :D
(start with LoginToFitbit(); After that you can start using GetSteps etc.)

**If you're going to use it with Android you'll really want to check out the blogpost above that shows you how to make the extra piece that you need to be able to get the callback back into your app. Without it, you won't get far. 
**If you're just using it on Desktop then it's fine, you should be able to just use the classes with no problem. The only caveat is that there is no way to grab the return code directly from the browser so your user will have to copy paste it manually.
