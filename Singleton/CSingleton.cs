using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Esta tecnica de singleton funciona cuando no usamos concurrencia/paralelismo.
    class CSingleton
    {
        //Aqui guardamos la únicxa instancia que va a existir
        private static CSingleton instancia;

        //Datos propios de la clase 
        private string nombre;
        private int edad;

        //Creamos el constructor privado
        private CSingleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static CSingleton ObtenInstancia()
        {
            //Verificamos si no existe la instancia
            if(instancia==null)
            {
                //Si no existe, instanciamos
                instancia = new CSingleton();
                Console.Write("---Instancia creada por primera vez");
            }

            //REgresamos la instancia
            return instancia;
        }

        //Aqui metodos propios de la clase
        public override string ToString()
        {
            return string.Format("La persona {0}, tiene edad de {1}",nombre, edad);
        }

        public void PonerDatos(string pNombre, int edad)
        {
            this.nombre = pNombre;
            this.edad = edad;
        }

        //Esto representa cualquier otro objeto
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
            Console.ReadKey();
        }
    }
}
