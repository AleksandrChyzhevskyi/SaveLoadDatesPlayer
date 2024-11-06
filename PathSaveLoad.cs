using System.IO;
using UnityEngine;

namespace _Development.Scripts.SaveLoadDatesPlayer
{
    public static class PathSaveLoad
    {
        public const string NamePlayerSkinDataFile = "PlayerSkinDataFile";
        public const string NameBeginnersFestFile = "BeginnersFest";
        public static readonly string ForFindPathToPlayerSkinDataFile = Path.Combine(Application.persistentDataPath + "/" + NamePlayerSkinDataFile);
        public static readonly string ForFindPathToBeginnersFestFile = Path.Combine(Application.persistentDataPath + "/" + NameBeginnersFestFile);
        public static readonly string ForFindPathToFileNotName = Path.Combine(Application.persistentDataPath + "/");
    }
}