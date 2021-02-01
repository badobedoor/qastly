using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using QuickLook;
using UIKit;

namespace qastly.iOS
{

    public class OpenFiles : QLPreviewItem
    {
        string filepath;
        string filename;
        public OpenFiles(string fileName, string filePath)
        {
            this.filepath = filePath;
            this.filename = fileName;
        }
        public override string ItemTitle
        {
            get
            {
                return filename;
            }
        }

        public override NSUrl ItemUrl
        {
            get
            {
                return NSUrl.FromFilename(filepath);
            }
        }
    }
}
