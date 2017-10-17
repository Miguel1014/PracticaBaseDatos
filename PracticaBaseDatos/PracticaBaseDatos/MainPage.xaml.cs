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
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                SQLiteAsyncConnection database;
                string db;
                db = DependencyService.Get<ISQLite>().GetLocalFilePath("Datos.db");
                database = new SQLiteAsyncConnection(db);
                database.CreateTableAsync<Datos>().Wait();


                var Insert = new Datos
                {
                    Matricula = 13090414,
                    Nombre = "Luis Miguel",
                    Apellidos = "Salvador Dominguez",
                    Direccion = "Calle Arboledas, San Fransisco Chimalpa, Naucalpan",
                    Telefono = 5522551455,
                    Carrera = "Ing. Sistemas Computacionales",
                    Semestre = 9,
                    Correo = "siul-leugim10hotmail.com",
                    Github = "github.com/Miguel1014"
                };

                database.InsertAsync(Insert);


                DisplayAlert("Aviso", "Tabla creada correctamente", "Ok");

              


            }
            catch
            {
                DisplayAlert("Aviso", "Error datos duplicados", "Ok");
            }

           



        }
    }
}