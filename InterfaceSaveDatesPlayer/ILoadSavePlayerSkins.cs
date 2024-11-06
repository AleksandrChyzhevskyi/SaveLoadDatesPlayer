using _Development.Scripts.SkinsPlayer.PlayerSkinsData;

namespace _Development.Scripts.SaveLoadDatesPlayer.InterfaceSaveDatesPlayer
{
    public interface ILoadSavePlayerSkins
    {
        void SavePlayerSkins(AllPlayerSkins data);
        AllPlayerSkins LoadPlayerSkins();
        void SaveDefaultEffect();
    }
}