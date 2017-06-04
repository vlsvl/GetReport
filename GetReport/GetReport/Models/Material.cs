using GetReport.ViewModels;
using System;
using System.IO;

namespace GetReport.Models
{
    [Serializable]
    public class Material:ViewModelBase
    {        
        //public string TypeOfDocs { get; set; }
        //public string NumberOfDocs { get; set; }
        //public DateTime DateOfOrderedOrVaranty { get; set; }
        private string _NameOfMaterial;

        public string NameOfMaterial
        {
            get { return _NameOfMaterial; }
            set { _NameOfMaterial = value;
                OnPropertyChanged("NameOfMaterial");
            }
        }

        private string _TypeOfDocs;

        public string TypeOfDocs
        {
            get { return _TypeOfDocs; }
            set { _TypeOfDocs = value;
                OnPropertyChanged("TypeOfDocs");
            }
        }

        private string _NumberOfDocs;

        public string NumberOfDocs
        {
            get { return _NumberOfDocs; }
            set { _NumberOfDocs = value;
                OnPropertyChanged("NumberOfDocs");
            }
        }

        private DateTime _DateOfOrderedOrVaranty;

        public DateTime DateOfOrderedOrVaranty
        {
            get { return _DateOfOrderedOrVaranty; }
            set { _DateOfOrderedOrVaranty = value;
                OnPropertyChanged("DateOfOrderedOrVaranty");
            }
        }

    }
}
