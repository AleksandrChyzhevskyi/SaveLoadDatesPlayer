using System.Collections.Generic;
using System.IO;
using _Development.Scripts.BeginnersFest.SaveLoadData;
using _Development.Scripts.Data;
using _Development.Scripts.SaveLoadDatesPlayer.InterfaceSaveDatesPlayer;
using _Development.Scripts.SkinsPlayer.PlayerSkinsData;
using BLINK.RPGBuilder.Characters;
using DevToDev.Analytics.ABTest;
using UnityEngine;

namespace _Development.Scripts.SaveLoadDatesPlayer
{
    public class LoadSave : ILoadSavePlayerSkins, ILoadSaveBeginnersFest
    {
        public void SaveBeginnersFest(ProgressPlayerBeginnersFest data)
        {
            Character.Instance.CharacterData.ProgressBeginnersFest = data;
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(PathSaveLoad.ForFindPathToBeginnersFestFile + ".txt", json);
        }

        public ProgressPlayerBeginnersFest LoadBeginnersFest()
        {
            string json = File.ReadAllText(PathSaveLoad.ForFindPathToBeginnersFestFile + ".txt");
            Character.Instance.CharacterData.ProgressBeginnersFest = JsonUtility.FromJson<ProgressPlayerBeginnersFest>(json);
            return Character.Instance.CharacterData.ProgressBeginnersFest;
        }

        public void SavePlayerSkins(AllPlayerSkins data)
        {
            Character.Instance.CharacterData.Skins = data;
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(PathSaveLoad.ForFindPathToPlayerSkinDataFile + ".txt", json);
        }

        public AllPlayerSkins LoadPlayerSkins()
        {
            string json = File.ReadAllText(PathSaveLoad.ForFindPathToPlayerSkinDataFile + ".txt");
            Character.Instance.CharacterData.Skins = JsonUtility.FromJson<AllPlayerSkins>(json);
            return Character.Instance.CharacterData.Skins;
        }

        public void SaveDefaultEffect()
        {
            if (Character.Instance.CharacterData.Skins.DataFiles.Count != 0)
                Character.Instance.CharacterData.Skins.DataFiles.Clear();

            int ShapeShiftId = Analytics.instance.RemoteConfigReceiveResult == DTDRemoteConfigReceiveResult.Success
                ? Analytics.instance.GetConfig(Analytics.ShapeShiftId)
                : (int)AnimalsToEffectID.Spider;

            Character.Instance.CharacterData.Skins.DataFiles.Add(CreateSkin(ShapeShiftId));
            SavePlayerSkins(Character.Instance.CharacterData.Skins);
        }

        private PlayerSkinDataFile CreateSkin(int ID)
        {
            PlayerSkinDataFile defaultSkin = new PlayerSkinDataFile
            {
                EffectID = ID,
                Skinslist = new List<SkinIDDataFile>()
                {
                    new()
                    {
                        SkinIDData = SkinID.DefaultSkin,
                        IsActive = true
                    }
                }
            };

            return defaultSkin;
        }
    }
}