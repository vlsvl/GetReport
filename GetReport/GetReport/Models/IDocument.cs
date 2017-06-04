using GetReport.ViewModels;
using System;

namespace GetReport.Models
{    
    interface IDocument
    {
        int ID { get; set; }
        string Author { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
    }
}
