using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ejerciciosColecciones
{
    class Program
    {
        private static  Dictionary<string, int> contadorDePalabras = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Mensaje();
            

            //tomo la cadena desde la consola
            string parrafo = tomarParrafoConsola();
            //spliteo la cadena que viene desde la consola
            string[] cadenaSpliteada = splitParrafo(parrafo);
            //con la cadena resultante del spliteo ,creo una lista con cada valor 
            List<string> parrafoList = new List<string>(cadenaSpliteada);
            //aca lleno el diccionario,con la funcion llenarDictionary
            llenarDictionary(parrafoList);
            Console.WriteLine("contenido del diccionario");
            //muestro los valores del diccionario
            imprimirDictionary(contadorDePalabras);
            //tambien muestro la cantidad de pares clave valor dentro del diccionario
            Console.WriteLine("size :"+contadorDePalabras.Count);

             
            
            Console.Read();
        }


        public static string tomarParrafoConsola()
        {
            string cadenaQueVieneDesdeConsola;


            return cadenaQueVieneDesdeConsola = Console.ReadLine();


        }

        #region spliteo
        //spliteo de cadena 
        public static string[] splitParrafo(string parrafo)

        {

            return parrafo.Split(' ');
        }

        #endregion
        #region Mensajes
        private static void Mensaje()
        {
            Console.WriteLine("ingrese un parrafo");
        }
        private static void mensajeSalida(string parrafoIngresado)
        {
            Console.WriteLine("el parrafo ingresado fue :{0}", parrafoIngresado);
        }

        private static void imprimir(string[] cadena )
        {
            foreach (var item in cadena)
            {
                Console.WriteLine($"<{item}>");
            }
        }
        #endregion
        #region Dictionary

        //aca lleno un diccionario lo que hago es recorrer una lista y por cada key que hay(item.Key) ,cuente la cantidad de apariciones(item.Count()) 
        //y por cada vuelta que agregue los resultados al diccionario
        public static void llenarDictionary(List<string> lista)
        {

            foreach (var item in lista.GroupBy(x => x))

            {

                contadorDePalabras.Add(item.Key, item.Count());

            }

        }
        public static void imprimirDictionary(Dictionary<string, int> dc)
        {
            foreach (var item in dc)
            {
                Console.WriteLine("{0}    {1} ", item.Key, item.Value);
            }
        } 
        #endregion
    }
}
