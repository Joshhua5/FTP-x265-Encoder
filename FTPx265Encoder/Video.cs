using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPx265Encoder
{
    [Serializable]
    public enum Status
    {
        Queued,
        Downloading,
        Uploading,
        Encoding,
        Failed,
        Bloated,
        Finished
    }

    [Serializable]
    public class Video
    {
        public string FullPath;
        public string Name;
        public string Format;
        // New details of the encoded video
        public string NewFullPath;
        public string NewName;

        public string Probe;

        public int DownloadPer;
        public int UploadPer;
        public int EncodeProgress;

        public int Duration; // Seconds 
        public int VideoSize;

        [NonSerialized]
        public Exception Error = null;
        public Status Status = Status.Queued;
        [NonSerialized]
        public ToolTip tip = null;
         
        public Uri NewUri
        {
            get
            {
                if (NewFullPath == null)
                    return null;
                return new Uri(NewFullPath);
            }
        }
         
        public Uri OriginalUri
        {
            get
            {
                if (FullPath == null)
                    return null;
                return new Uri(FullPath);
            }
        }

        override public string ToString()
        {
            return Name;
        }
    }
}
