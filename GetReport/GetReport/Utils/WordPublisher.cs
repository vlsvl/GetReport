using GetReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReport.Utils
{
    class WordPublisher : IPublisher<Report>
    {
        public void GetPublish(Dictionary<string, string> publishRules, System.Collections.ObjectModel.ObservableCollection<Report> collect, string filePath)
        {
            throw new NotImplementedException();
        }

        public void GetPublish(Dictionary<string, string> publishRules, Report entity, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
