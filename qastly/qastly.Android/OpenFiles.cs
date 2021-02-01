using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using qastly.Droid;
using qastly.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenFiles))]
namespace qastly.Droid
{
    public class OpenFiles 
    {
        public OpenFiles()
        {
        }

        //public class OpenFiles : IOpenFile
        //public void OpenFile(string path)
        //{
            
        //    var localFile = new Java.IO.File(path);   // getting files from path
        //    var currentContext = Android.App.Application.Context;
        //    var uri = FileProvider.GetUriForFile(currentContext, "com.demo.qastly.provider", localFile);

        //    Intent intent = new Intent(Intent.ActionView);
        //    intent.SetFlags(ActivityFlags.ClearWhenTaskReset | ActivityFlags.NewTask);
        //    var extension = MimeTypeMap.GetFileExtensionFromUrl(path);
        //    var mimeType = MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension.ToLower());
        //    intent.AddFlags(ActivityFlags.GrantReadUriPermission);
        //    intent.SetDataAndType(uri, mimeType);
        //    currentContext.StartActivity(intent);
        //}
    }
}


