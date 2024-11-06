using _Development.Scripts.BeginnersFest.SaveLoadData;

namespace _Development.Scripts.SaveLoadDatesPlayer.InterfaceSaveDatesPlayer
{
    public interface ILoadSaveBeginnersFest
    {
        void SaveBeginnersFest(ProgressPlayerBeginnersFest data);
        ProgressPlayerBeginnersFest LoadBeginnersFest();
    }
}