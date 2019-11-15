using Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IUR_p07
{
    public class MainViewModel : ViewModelBase
    {
        private string _filepath;
        public string Filepath
        {
            get { return _filepath; }
            set { SetProperty(ref _filepath, value); }
        }

        private RecentFileViewModel _selectedRecentFile;
        public RecentFileViewModel SelectedRecentFile
        {
            get { return _selectedRecentFile; }
            set { SetProperty(ref _selectedRecentFile, value); }
        }

        private ICommand _previewCommand;
        public ICommand PreviewCommand
        {
            get { return _previewCommand; }
            set { SetProperty(ref _previewCommand, value); }
        }

        private ObservableCollection<RecentFileViewModel> _recentFiles = new ObservableCollection<RecentFileViewModel>();
        public ObservableCollection<RecentFileViewModel> RecentFiles
        {
            get { return _recentFiles; }
            set { SetProperty(ref _recentFiles, value); }
        }

        public MainViewModel()
        {
            Filepath = @"myfile.html";

            PreviewCommand = new RelayCommand((obj) => { Console.WriteLine(Filepath); });

            RecentFiles.Add(new RecentFileViewModel() { Path = @"C:\text1.txt", FileType = @"file/text", PreviewText = @"This is a preview" });
            RecentFiles.Add(new RecentFileViewModel() { Path = @"C:\folder1\folder2\folder3\text1.txt", FileType = @"file/text", PreviewText = @"This is a preview" });
            RecentFiles.Add(new RecentFileViewModel() { Path = @"C:\text1.txt", FileType = @"file/text", PreviewText = @"This is a preview" });
            RecentFiles.Add(new RecentFileViewModel() { Path = @"C:\text1.txt", FileType = @"file/text", PreviewText = @"This is a preview" });
            RecentFiles.Add(new RecentFileViewModel() { Path = @"C:\text1.txt", FileType = @"file/text", PreviewText = @"This is a preview" });
        }

        public void SetRecentAsCurrent()
        {
            Filepath = SelectedRecentFile.Path;
        }

    }
}
