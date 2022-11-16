using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Ano_Publicacao { get; set; }
        public string Estilo_Literario { get; set; }
        public int Numero_Paginas { get; set; }
        public string Pais_Publicacao{ get; set; }

        
        public Livro(string isbn, string titulo)
        {
            this.ISBN = isbn;   
            this.Titulo = titulo;
        }
    }
}
