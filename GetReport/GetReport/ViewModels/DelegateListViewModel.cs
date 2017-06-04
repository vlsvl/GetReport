using GetReport.Models;
using GetReport.Tools;
using GetReport.Utils;
using MvvmDialogs;
using MvvmDialogs.FrameworkDialogs.OpenFile;
using MvvmDialogs.FrameworkDialogs.SaveFile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GetReport.ViewModels
{
    class DelegateListViewModel : ViewModelBase, IModalDialogViewModel
    {
        public DialogService DialogService { get; private set; }
        public bool? DialogResult { get { return false; } }

        private ObservableCollection<Representative> _DelegateList;
        public ObservableCollection<Representative> DelegateList
        {
            get { return _DelegateList; }
            set { _DelegateList = value; OnPropertyChanged("DelegateList"); }
        }

        XmlFileService<Representative> fileService { get; set; }

        public ICommand SaveDLCmd { get { return new RelayCommand(OnSaveDelegateList); } }

        private string fileName;
        private void OnSaveDelegateList()
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
                fileService.Save(settings.FileName, DelegateList);
                Log.Info("Saving file: " + settings.FileName);
            }
        }

        public ICommand OpenDLCmd { get { return new RelayCommand(OnOpenDelegateList); } }

        

        private void OnOpenDelegateList()
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
                DelegateList = fileService.Open(settings.FileName);
                // Do something
                Log.Info("Opening file: " + settings.FileName);
                
            }
        }

        public DelegateListViewModel()
        {
            this.DialogService = new MvvmDialogs.DialogService();
            this.fileService = new XmlFileService<Representative>();
            this.DelegateList = new ObservableCollection<Representative>();
        }
    }
}
