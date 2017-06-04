using MvvmDialogs;
using log4net;
using MvvmDialogs.FrameworkDialogs.OpenFile;
using MvvmDialogs.FrameworkDialogs.SaveFile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Input;
using System.Xml.Linq;
using GetReport.Views;
using GetReport.Utils;
using GetReport.Models;
using GetReport.Tools;

namespace GetReport.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        #region Propertyes
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Report> _ReportList;
        public ObservableCollection<Report> ReportList
        {
            get { return _ReportList; }
            set { _ReportList = value; OnPropertyChanged("ReportList"); }
        }

        private ObservableCollection<Representative> _DelegateList;
        public ObservableCollection<Representative> DelegateList
        {
            get { return _DelegateList; }
            set { _DelegateList = value; OnPropertyChanged("DelegateList"); }
        }

        private Report _SelectedReport;
        public Report SelectedReport
        {
            get { return _SelectedReport; }
            set { _SelectedReport = value; OnPropertyChanged("SelectedReport"); }
        }

        XmlFileService<Report> fileService { get; set; } 

        //Свойства для активации/деактивации элементов управления.
        private bool _NewSessionE;
        public bool NewSessionE { get { return _NewSessionE; } set { _NewSessionE = value; OnPropertyChanged("NewSessionE"); } }

        private bool _OpenSessionE;
        public bool OpenSessionE { get { return _OpenSessionE; } set { _OpenSessionE = value; OnPropertyChanged("OpenSessionE"); } }

        private bool _SaveSessionE;
        public bool SaveSessionE { get { return _SaveSessionE; } set { _SaveSessionE = value; OnPropertyChanged("SaveSessionE"); } }

        private bool _SaveAsSessionE;
        public bool SaveAsSessionE { get { return _SaveAsSessionE; } set { _SaveAsSessionE = value; OnPropertyChanged("SaveAsSessionE"); } }

        private bool _AddReportToListE;
        public bool AddReportToListE { get { return _AddReportToListE; } set { _AddReportToListE = value; OnPropertyChanged("AddReportToListE"); } }

        private bool _DeleteReportFromListE;
        public bool DeleteReportFromListE { get { return _DeleteReportFromListE; } set { _DeleteReportFromListE = value; OnPropertyChanged("DeleteReportFromListE"); } }        
        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Parameters
        private readonly IDialogService DialogService;

        /// <summary>
        /// Title of the application, as displayed in the top bar of the window
        /// </summary>
        public string Title
        {
            get { return "GetReport"; }
        }
        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Constructors
        public MainViewModel()
        {
            // DialogService is used to handle dialogs
            this.DialogService = new MvvmDialogs.DialogService();
            this.fileService = new XmlFileService<Report>();
            NewSessionE = true;
            OpenSessionE = true;
            SaveSessionE = false;
            SaveAsSessionE = false;
            AddReportToListE = false;
            DeleteReportFromListE = false;
        }

        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Methods

        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Commands
        public RelayCommand<object> SampleCmdWithArgument { get { return new RelayCommand<object>(OnSampleCmdWithArgument); } }

        public ICommand SaveAsCmd { get { return new RelayCommand(OnSaveAsTest); } }
        public ICommand SaveCmd { get { return new RelayCommand(OnSaveTest); } }
        public ICommand NewCmd { get { return new RelayCommand(OnNewTest); } }
        public ICommand OpenCmd { get { return new RelayCommand(OnOpenTest); } }
        public ICommand ShowAboutDialogCmd { get { return new RelayCommand(OnShowAboutDialog); } }
        public ICommand ShowDelegateListDialogCmd { get { return new RelayCommand(OnShowDelegateListDialog); } }
        public ICommand ExitCmd { get { return new RelayCommand(OnExitApp); } }
        public ICommand AddReportToList { get { return new RelayCommand(OnAddReportToList); } }
        public ICommand DeleteReportFromList { get { return new RelayCommand(OnDeleteReportFromList); } }

        private void OnSampleCmdWithArgument(object obj)
        {
            // TODO
        }

        private string fileName;
        private void OnSaveAsTest()
        {
            var settings = new SaveFileDialogSettings
            {
                Title = "Save As",
                Filter = "File (.xml)|*.xml",
                CheckFileExists = false,
                OverwritePrompt = true
            };

            bool? success = DialogService.ShowSaveFileDialog(this, settings);
            if (success == true)
            {
                // Do something
                fileName = settings.FileName;
                fileService.Save(settings.FileName, ReportList);
                Log.Info("Saving file: " + settings.FileName);
            }
        }
        private void OnSaveTest()
        {
            if (fileName == null)
            {
                OnSaveAsTest();
            }
            else
            {
                fileService.Save(fileName, ReportList);
                Log.Info("Saving file: " + fileName);
            }
            
            // TODO
        }
        private void OnNewTest()
        {
            if (ReportList == null)
            {
                ReportList = new ObservableCollection<Report>();
                NewSessionE = false;
                OpenSessionE = false;
                SaveSessionE = true;
                SaveAsSessionE = true;
                AddReportToListE = true;
                DeleteReportFromListE = true;
            }
            else
            {
                DialogService.ShowMessageBox(this, "File already loaded.", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error, System.Windows.MessageBoxResult.None);
            }
            // TODO
        }
        private void OnOpenTest()
        {
            var settings = new OpenFileDialogSettings
            {
                Title = "Open",
                Filter = "Sample (.xml)|*.xml",
                CheckFileExists = false
            };

            bool? success = DialogService.ShowOpenFileDialog(this, settings);
            if (success == true)
            {
                fileName = settings.FileName;
                ReportList = fileService.Open(settings.FileName);
                // Do something
                Log.Info("Opening file: " + settings.FileName);
            }
        }
        private void OnShowAboutDialog()
        {
            Log.Info("Opening About dialog");
            AboutViewModel dialog = new AboutViewModel();
            var result = DialogService.ShowDialog<About>(this, dialog);
        }
        private void OnShowDelegateListDialog()
        {
            Log.Info("Opening DelegateList dialog");
            DelegateListViewModel dialog = new DelegateListViewModel();
            var result = DialogService.ShowDialog<DelegateList>(this, dialog);
        }
        private void OnExitApp()
        {
            System.Windows.Application.Current.MainWindow.Close();
        }
        private void OnAddReportToList()
        {
            ReportList.Add(new Report());
            DeleteReportFromListE = true;
        }

        private void OnDeleteReportFromList()
        {
            if (SelectedReport != null)            
            ReportList.Remove(SelectedReport);
            if (ReportList.Count == 0)
                DeleteReportFromListE = false;
        }
        #endregion

        #region Events
        
        #endregion
    }
}
