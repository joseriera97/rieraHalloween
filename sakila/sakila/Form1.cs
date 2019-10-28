using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sakila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Preparar la conexión para la BBDD.
        private const string connectionString = "Server=localhost;Database=sakila;Uid=usuari;Pwd=seCret_16";
        private string Usuario="";

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FilmsFind_Click(object sender, EventArgs e)
        {
            /*Botón de busqueda*/

            //Creamos listado de peliculas.
            List<Film> films = new List<Film>(); 
            
            /*
            string queryDetallesFilm = "select f.length, f.description,f.rating ,f.title,lang.name ,f.description from film as f, language  as lang where f.language_id  = lang.language_id ";
            */
            //Preparo la conexión
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Preparamos la query para obtener todos los usuarios que tengan apellido = al textSurname
            string buscarFilm = $"SELECT  film.title FROM sakila.film" +
                $" WHERE title LIKE '%{FilmsBox.Text}%'";

            films = connection.Query<Film>(buscarFilm).ToList();
            FilmsList.DataSource = films;
            FilmsList.DisplayMember = "title";
            connection.Close();

        }

        private void FilmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            Film selectedFilm = FilmsList.SelectedItem as Film;
            DetailFilm detailFilm = new DetailFilm(selectedFilm);


            //Button prop DialogResult

            DialogResult result = detailFilm.ShowDialog(this);
        }


        private void buttonLog_Click(object sender, EventArgs e)
        {
             int usuarios = 0;
            //realizar el login
            //Creamos listado de peliculas.
            //Comprobamos que el usuario este en staff.
            MySqlConnection connection = new MySqlConnection(connectionString);

            //query para comprobar si el usuario esta en staff.
            string userStaff = $"SELECT  staff.username,staff.password FROM sakila.staff" + $" WHERE username LIKE '%{textUser.Text}%' and password LIKE '%{textPassword.Text}%'";

            //Intento de comprobar si da un resultado con count.
            //
           usuarios = connection.Query(userStaff).Count();


            if (usuarios != 0) {
                Usuario = textUser.Text;
                //Solo se puedda leeer
                textUser.ReadOnly = true;
                textPassword.ReadOnly = true;
                //no este disponible
                textUser.Enabled = false;
                textPassword.Enabled = false;

            }
            else
            {
                //En el caso de error mostrar el mensaje de error.
                textPassword.Visible = true;
            }

        }
        }
    }

