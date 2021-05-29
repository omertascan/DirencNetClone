using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DirencNetClone.Droid;
using DirencNetClone.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace DirencNetClone.Droid
{
  public  class SQLite_Android :ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;

        }
    }
}