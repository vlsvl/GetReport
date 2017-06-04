using System.Collections.ObjectModel;

namespace GetReport.Tools
{
    interface IFileService<T>
    {
        ObservableCollection<T> Open(string filename);
        void Save(string filename, ObservableCollection<T> list);
    }
}
