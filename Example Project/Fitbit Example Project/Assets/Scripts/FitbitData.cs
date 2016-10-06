using System;
using System.Collections.Generic;

namespace Assets.Scripts.Fitbit
{
    /// <summary>
    /// Holder class for Fitbit pulled Data.
    /// </summary>
    public class FitbitData
    {
        public string CurrentTab = "Profile";

        public Dictionary<string, string> RawProfileData;
        public Dictionary<string, string> ProfileData;

        public int CurrentSteps;
        public int LastSteps;

        public double CurrentDistance;
        public double LastDistance;

        public int CurrentCalories;
        public int LastCalories;

        public int CurrentSleep;
        public int LastSleep;
        
        public DateTime LastSyncTime;
        
        public enum summary
        {
            activityCalories,caloriesBMR,caloriesOut,distances,activityDistance,distance,
            elevation,fairlyActiveMinutes,floors,lightlyActiveMinutes,marginalCalories,sedentaryMinutes,
            steps,veryActiveMinutes
        }

        public FitbitData()
        {
            RawProfileData =new Dictionary<string, string>();
            ProfileData = new Dictionary<string, string>();

            //we will build the Profile Data Keys that we want so we can compare them later
            //to decide what we keep and what we don't when we get the actual data
            ProfileData.Add("age","");
            ProfileData.Add("avatar","");
            ProfileData.Add("averageDailySteps","");
            ProfileData.Add("city","");
            ProfileData.Add("country","");
            ProfileData.Add("dateOfBirth","");
            ProfileData.Add("gender","");
            ProfileData.Add("memberSince","");
        }
    }
}
