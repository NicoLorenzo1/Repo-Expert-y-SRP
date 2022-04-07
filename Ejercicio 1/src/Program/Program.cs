using System;

namespace SRP
{

    class Program
    {
        static void Main(string[] args)
        {
            // se crea una instancia de Biblioteca llamada biblioteca.
            Biblioteca biblioteca = new Biblioteca();
            Libro libro1 = new Libro("Design Patterns", "Erich Gamma & Others", "001-034");
            Libro libro2 = new Libro("Pro C#", "Troelsen", "001-035");
            //se llama al metodo AlmacenarLibro que esta en la clase biblioteca y se le pasan los parametros necesarios, entre ellos se encuentran el objeto creado de tipo libro, el sector y el estante, ambos de tipo string.
            biblioteca.AlmacenarLibro(libro1, "A", "7");
            biblioteca.AlmacenarLibro(libro2, "b", "8");
        }
    }
}
