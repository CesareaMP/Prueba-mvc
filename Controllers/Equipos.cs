using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using asdasdadasdasd.Models;

namespace asdasdadasdasd.Controllers
{
    public class EquiposController : Controller
    {      
        public List<Equipos> equipos = new List<Equipos>();
        [HttpGet]
        [Route("/")]
        public List<Equipos> guardadoequipo()
        {
            string ubicacionArchivo = "asdasdas.csv";
            System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
            string separador = ",";
            string linea;
            int contador = 0;
            while ((linea = archivo.ReadLine()) != null)
            {
                contador = 0;
                string equipo1 = linea.Split(separador)[contador++];
                string coach1 = linea.Split(separador)[contador++];
                string liga1 = linea.Split(separador)[contador++];
                DateTime fecha1 = Convert.ToDateTime(linea.Split(separador)[contador++]);
                List<Jugadores> temporal = new List<Jugadores>();
                for (int i = 0; i <= 4; i++)
                {
                    contador = 0;
                    linea = archivo.ReadLine();
                    string nombre1 = linea.Split(separador)[contador++];
                    string apellido1 = linea.Split(separador)[contador++];
                    string rol1 = linea.Split(separador)[contador++];
                    int kills1 = Convert.ToInt32(linea.Split(separador)[contador++]);                    
                    int assist1 = Convert.ToInt32(linea.Split(separador)[contador++]);                    
                    int defeat1 = Convert.ToInt32(linea.Split(separador)[contador++]);    
                    double cs1 = Convert.ToDouble(linea.Split(separador)[contador++]);                                                               
                    temporal.Add(new Jugadores {nombre=nombre1, apellido=apellido1, rol=rol1, kills=kills1, defeat=defeat1, assist=assist1, creepscore=cs1  });
                }
                equipos.Add(new Equipos {equipo=equipo1,coach=coach1,liga=liga1,fecha=fecha1,jugador=temporal});                 
            }
            return equipos; 
        }
        
    }
}
