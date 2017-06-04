using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReport.Utils
{
    interface IPublisher<T>
    {
        void GetPublish(Dictionary<string, string> publishRules, ObservableCollection<T> collect, string filePath);
        void GetPublish(Dictionary<string, string> publishRules, T entity, string fileName);
    }
}
