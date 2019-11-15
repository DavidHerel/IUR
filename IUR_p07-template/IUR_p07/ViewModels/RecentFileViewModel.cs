using Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUR_p07
{
    public class RecentFileViewModel : ViewModelBase
    {
        private string _path;
        public string Path
        {
            get { return _path; }
            set { SetProperty(ref _path, value); }
        }

        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { SetProperty(ref _fileType, value); }
        }

        private string _previewText;
        public string PreviewText
        {
            get { return _previewText; }
            set { SetProperty(ref _previewText, value); }
        }

    }
}
