using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace asdasdadasdasd.Models
{
    public class Equipos
    {
   
        public string equipo { get; set; }
        public string coach { get; set; }
        public string liga { get; set; }
        public DateTime fecha { get; set; }

        public List<Jugadores> jugador = new List<Jugadores>();
    }   
}