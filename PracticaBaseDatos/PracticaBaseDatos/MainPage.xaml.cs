using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace PracticaBaseDatos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {    
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Datos.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<Datos>().Wait();
        }
    }
}
