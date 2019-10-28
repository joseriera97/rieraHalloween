using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakila
{
    class Film
    {
        //Solo el titulo
        public string title { get; set; }

        public string description { get; set; }
        public int rating { get; set; }
        public int length { get; set; }



        //Obtener los campos detallados.
        public string FullInfo
        {
            get
            {
                return description + rating + length + title;
            }
        }
      

    }
}
