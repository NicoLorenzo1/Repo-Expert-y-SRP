using System;

namespace SRP

{
    /// <summary>
    /// Se crea la clase biblioteca y tiene un método Almacenar libro al cual se le pasa un libro, un sector y un estante para que esta cumpla con el patrón SRP
    /// </summary>
    public class Biblioteca
    {

        public string SectorBiblioteca { get; set; }
        public string EstanteBiblioteca { get; set; }

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            SectorBiblioteca = sector;
            EstanteBiblioteca = estante;

            Console.WriteLine($"Se almacenó el libro {libro.Titulo} en el sector {sector} estante {estante}");
        }
    }
}

