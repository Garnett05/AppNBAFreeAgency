using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppNBAFreeAgency.Database;
//using System.Runtime.CompilerServices; // Without removing that, the assembly doesn't work
using AppNBAFreeAgency.Droid.Database;
using Xamarin.Forms;

[assembly:Dependency(typeof(DroidFolderPath))] // need to add 'using Xamarin.Forms' to use the assembly
namespace AppNBAFreeAgency.Droid.Database
{
    public class DroidFolderPath : IDatabasePath
    {
        public string GetPath(string DatabaseName)
        {                        
            //android folder path
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string dbPath = System.IO.Path.Combine(folderPath, DatabaseName);
            return dbPath;
        }
    }
}