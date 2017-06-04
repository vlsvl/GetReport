using GetReport.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace GetReport.Models
{
    
    [Serializable]
    public class Report : ViewModelBase //, IDocument
    {
        #region Fields
        private string _NameAndAddressOfObject;
        private string _RequisitesOfConsumer;
        private string _RequisitesOfPrimeContractor;
        private string _RequisitesOfProjectDeveloper;
        private string _RequisitesOfBuilder;
        private string _TypeOfReport;
        private DateTime _DateOfPreparationOfReport;
        private string _NumberOfReport;
        private Representative _DelegateOfConsumer;
        private Representative _DelegateOfPrimeContractor;
        private Representative _DelegateOfBuildControlPrimeContractor;
        private Representative _DelegateOfProjectDeveloper;
        private Representative _DelegateOfBuilder;
        private Representative _DelegateOfOtherCompany;
        private Representative _DelegateOfOtherCompany2;
        private Representative _DelegateOfOtherCompany3;
        private string _Builder;
        private string _WorkName;
        private string _ProjectTheWorkIncluded;
        private ObservableCollection<Material> _TheListOfMaterial;
        private string _TheListOfQuantityConsistDocs;
        private DateTime _TheDateOfWorkStart;
        private DateTime _TheDateOfWorkEnding;
        private string _TheListOfDocumentConsists;
        private string _TheNextWorkIsAccepted;
        private string _Annexes;
        #endregion

        #region Props


        /// <summary>
        /// Название объекта.
        /// </summary>
        public string NameAndAddressOfObject
        {
            get
            {
                return _NameAndAddressOfObject;
            }
            set
            {
                _NameAndAddressOfObject = value;
                OnPropertyChanged("NameAndAddressOfObject");
            }
        }

        
        /// <summary>
        /// Реквизиты заказчика или техзаказчика согласно требованиям РД 11-02-2006.
        /// </summary>
        public string RequisitesOfConsumer
        {
            get
            {
                return _RequisitesOfConsumer;
            }
            set
            {
                _RequisitesOfConsumer = value;
                OnPropertyChanged("RequisitesOfConsumer");
            }
        }

        
        /// <summary>
        /// Реквизиты генподрядчика согласно требованиям РД 11-02-2006.
        /// </summary>
        public string RequisitesOfPrimeContractor
        {
            get
            {
                return _RequisitesOfPrimeContractor;
            }
            set
            {
                _RequisitesOfPrimeContractor = value;
                OnPropertyChanged("RequisitesOfPrimeContractor");
            }
        }
        
        
        /// <summary>
        /// Реквизиты разработчика документации согласно требованиям РД 11-02-2006.
        /// </summary>
        public string RequisitesOfProjectDeveloper
        {
            get
            {
                return _RequisitesOfProjectDeveloper;
            }
            set
            {
                _RequisitesOfProjectDeveloper = value;
                OnPropertyChanged("RequisitesOfProjectDeveloper");
            }
        }
        
        
        /// <summary>
        /// Реквизиты исполнителя работ согласно требованиям РД 11-02-2006.
        /// </summary>
        public string RequisitesOfBuilder
        {
            get
            {
                return _RequisitesOfBuilder;
            }
            set
            {
                _RequisitesOfBuilder = value;
                OnPropertyChanged("RequisitesOfBuilder");
            }
        }
        
        
        /// <summary>
        /// Тип акта.
        /// </summary>
        public string TypeOfReport
        {
            get
            {
                return _TypeOfReport;
            }
            set
            {
                _TypeOfReport = value;
                OnPropertyChanged("TypeOfReport");
            }
        }
        
        
        /// <summary>
        /// Дата подписания акта.
        /// </summary>
        public DateTime DateOfPreparationOfReport
        {
            get
            {
                return _DateOfPreparationOfReport;
            }
            set
            {
                _DateOfPreparationOfReport = value;
                OnPropertyChanged("DateOfPreparationOfReport");
            }
        }
        
        
        /// <summary>
        /// Номер акта.
        /// </summary>
        public string NumberOfReport
        {
            get
            {
                return _NumberOfReport;
            }
            set
            {
                _NumberOfReport = value;
                OnPropertyChanged("NumberOfReport");
            }
        }
        /// <summary>
        /// Представитель заказчика или техзаказчика.
        /// </summary>
        public Representative DelegateOfConsumer
        {
            get
            {
                return _DelegateOfConsumer;
            }
            set
            {
                _DelegateOfConsumer = value;
                OnPropertyChanged("DelegateOfConsumer");
            }
        }
        /// <summary>
        /// Представитель генподрядчика.
        /// </summary>
        public Representative DelegateOfPrimeContractor
        {
            get
            {
                return _DelegateOfPrimeContractor;
            }
            set
            {
                _DelegateOfPrimeContractor = value;
                OnPropertyChanged("DelegateOfPrimeContractor");
            }
        }
        /// <summary>
        /// Представитель осуществляющий строительный контроль.
        /// </summary>
        public Representative DelegateOfBuildControlPrimeContractor
        {
            get
            {
                return _DelegateOfBuildControlPrimeContractor;
            }
            set
            {
                _DelegateOfBuildControlPrimeContractor = value;
                OnPropertyChanged("DelegateOfBuildControlPrimeContractor");
            }
        }
        /// <summary>
        /// Представитель проектировщика, осуществляющего авторский надзор, в случаях, когда он осуществляется.
        /// </summary>
        public Representative DelegateOfProjectDeveloper
        {
            get
            {
                return _DelegateOfProjectDeveloper;
            }
            set
            {
                _DelegateOfProjectDeveloper = value;
                OnPropertyChanged("DelegateOfProjectDeveloper");
            }
        }
        /// <summary>
        /// Представитель лица осуществляющего строительство.
        /// </summary>
        public Representative DelegateOfBuilder
        {
            get
            {
                return _DelegateOfBuilder;
            }
            set
            {
                _DelegateOfBuilder = value;
                OnPropertyChanged("DelegateOfBuilder");
            }
        }
        /// <summary>
        /// Представители иных лиц.
        /// </summary>
        public Representative DelegateOfOtherCompany
        {
            get
            {
                return _DelegateOfOtherCompany;
            }
            set
            {
                _DelegateOfOtherCompany = value;
                OnPropertyChanged("DelegateOfOtherCompany");
            }
        }
        /// <summary>
        /// Представители иных лиц.
        /// </summary>
        public Representative DelegateOfOtherCompany2
        {
            get
            {
                return _DelegateOfOtherCompany2;
            }
            set
            {
                _DelegateOfOtherCompany2 = value;
                OnPropertyChanged("DelegateOfOtherCompany2");
            }
        }
        /// <summary>
        /// Представители иных лиц.
        /// </summary>
        public Representative DelegateOfOtherCompany3
        {
            get
            {
                return _DelegateOfOtherCompany3;
            }
            set
            {
                _DelegateOfOtherCompany3 = value;
                OnPropertyChanged("DelegateOfOtherCompany3");
            }
        }
        /// <summary>
        /// Лицо выполнившее работы.
        /// </summary>
        public string Builder
        {
            get
            {
                return _Builder;
            }
            set
            {
                _Builder = value;
                OnPropertyChanged("Builder");
            }
        }
        /// <summary>
        /// 1. К освидетельствованию предъявлены следующие работы
        /// </summary>
        public string WorkName
        {
            get
            {
                return _WorkName;
            }
            set
            {
                _WorkName = value;
                OnPropertyChanged("WorkName");
            }
        }
        /// <summary>
        /// Работы выполнены в соответствии с разделами проектной документации.
        /// </summary>
        public string ProjectTheWorkIncluded
        {
            get
            {
                return _ProjectTheWorkIncluded;
            }
            set
            {
                _ProjectTheWorkIncluded = value;
                OnPropertyChanged("ProjectTheWorkIncluded");
            }
        }
        /// <summary>
        /// При выполнении работ применены
        /// </summary>
        public ObservableCollection<Material> TheListOfMaterial
        {
            get
            {
                return _TheListOfMaterial;
            }
            set
            {
                _TheListOfMaterial = value;
                OnPropertyChanged("TheListOfMaterial");
            }
        }
        /// <summary>
        /// Предъявлены документы, подтверждающие соответствие работ предъявляемым к ним требованиям
        /// </summary>
        public string TheListOfQuantityConsistDocs
        {
            get
            {
                return _TheListOfQuantityConsistDocs;
            }
            set
            {
                _TheListOfQuantityConsistDocs = value;
                OnPropertyChanged("TheListOfQuantityConsistDocs");
            }
        }
        /// <summary>
        /// Дата начала работ.
        /// </summary>
        public DateTime TheDateOfWorkStart
        {
            get
            {
                return _TheDateOfWorkStart;
            }
            set
            {
                _TheDateOfWorkStart = value;
                OnPropertyChanged("TheDateOfWorkStart");
            }
        }
        /// <summary>
        /// Дата окончания работ.
        /// </summary>
        public DateTime TheDateOfWorkEnding
        {
            get
            {
                return _TheDateOfWorkEnding;
            }
            set
            {
                _TheDateOfWorkEnding = value;
                OnPropertyChanged("TheDateOfWorkEnding");
            }
        }
        /// <summary>
        /// Работы выполнены в соответствии. 
        /// </summary>
        public string TheListOfDocumentConsists
        {
            get
            {
                return _TheListOfDocumentConsists;
            }
            set
            {
                _TheListOfDocumentConsists = value;
                OnPropertyChanged("TheListOfDocumentConsists");
            }
        }
        /// <summary>
        /// Разрешается производство последующих работ.
        /// </summary>
        public string TheNextWorkIsAccepted
        {
            get
            {
                return _TheNextWorkIsAccepted;
            }
            set
            {
                _TheNextWorkIsAccepted = value;
                OnPropertyChanged("TheNextWorkIsAccepted");
            }
        }
        /// <summary>
        /// Приложения.
        /// </summary>
        public string Annexes
        {
            get
            {
                return _Annexes;
            }
            set
            {
                _Annexes = value;
                OnPropertyChanged("Annexes");
            }
        }

        //public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public DateTime ChangeDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion


        public Report()
        {
            DateOfPreparationOfReport = DateTime.Now;
            TheDateOfWorkStart = DateTime.Now;
            TheDateOfWorkEnding = DateTime.Now;
        }

    }
}
