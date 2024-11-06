using System;
using UnityEngine;

namespace _Development.Scripts.SaveLoadDatesPlayer.SaveLoadPrefs
{
    public static class SaveLoadPlayerPrefs
    {
        private const string DevToDevUserID = "DevToDevUserID";
        private const string RecordScoreInfinityMode = "RecordScoreInfinityMode";
        private const string PushPermissionRequestState = "PushPermissionRequestState";

        public static bool IsRecordScoreInfinityMode() =>
            PlayerPrefs.HasKey(RecordScoreInfinityMode);

        public static bool IsHaveDevToDevUserID() =>
            PlayerPrefs.HasKey(DevToDevUserID);

        public static bool IsHavePushPermissionRequestState() => 
            PlayerPrefs.HasKey(PushPermissionRequestState);

        public static void SaveRecordScoreInfinityMode(int score) =>
            PlayerPrefs.SetInt(RecordScoreInfinityMode, score);

        public static int LoadRecordScoreInfinityMode() =>
            PlayerPrefs.GetInt(RecordScoreInfinityMode);

        public static void SaveDevToDevUserID(string ID) =>
            PlayerPrefs.SetString(DevToDevUserID, ID);

        public static string LoadDevToDevUserID() =>
            PlayerPrefs.GetString(DevToDevUserID);

        public static void SavePushPermissionRequestState(int State) =>
            PlayerPrefs.SetInt(PushPermissionRequestState, State);

        public static bool LoadPushPermissionRequestState() =>
            Convert.ToBoolean(PlayerPrefs.GetInt(PushPermissionRequestState));
    }
}