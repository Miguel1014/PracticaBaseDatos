﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using System.IO;
using PracticaBaseDatos.Droid;

[assembly: Dependency(typeof(BD_Droid))]
namespace PracticaBaseDatos.Droid
{
    public class ISQLite_Android : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}