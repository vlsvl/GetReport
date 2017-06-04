using GetReport.ViewModels;
using System;

namespace GetReport.Models
{
    /// <summary>
    /// Класс представителя участвующего в подписании акта.
    /// </summary>
    [Serializable]
    public class Representative:ViewModelBase
    {
        private int _CountNumber;
        private string _FirstName;

        private string _LastName;
  
        private string _Patronymic;
 
        private string _Post;
 
        private string _Company;
 
        private string _Order;

        #region Properties
        /// <summary>
        /// Имя представителя.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        /// <summary>
        /// Фамилия представителя.
        /// </summary>
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        /// <summary>
        /// Отчество представителя.
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _Patronymic;
            }
            set
            {
                _Patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }
        /// <summary>
        /// Должность представителя.
        /// </summary>
        public string Post
        {
            get
            {
                return _Post;
            }
            set
            {
                _Post = value;
                OnPropertyChanged("Post");
            }
        }
        /// <summary>
        /// Компания представителя.
        /// </summary>
        public string Company
        {
            get
            {
                return _Company;
            }
            set
            {
                _Company = value;
                OnPropertyChanged("Company");
            }
        }
        /// <summary>
        /// Приказ на представителя подтверждающий полномочия.
        /// </summary>
        public string Order
        {
            get
            {
                return _Order;
            }
            set
            {
                _Order = value;
                OnPropertyChanged("Order");
            }
        }

        public int CountNumber
        {
            get => _CountNumber;
            set
            {
                _CountNumber = value;
                OnPropertyChanged("CountNumber");
            }
        }
        #endregion

        #region Ctor
        public Representative(int CountNumber, string FirstName, string LastName, string Patronymic, string Post, string Company, string Order)
        {
            this.CountNumber = CountNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.Post = Post;
            this.Company = Company;
            this.Order = Order;
        }

        public Representative()
        {

        }
        #endregion 
    }
}
