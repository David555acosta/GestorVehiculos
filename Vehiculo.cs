using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Crea una clase base llamada Vehiculo con propiedades privadas:
Marca (string)
Modelo (string)
Año (int)
Agrega un método virtual MostrarDetalles() que muestre la información del vehículo.
Agrega un método abstracto EvaluarVehiculo() que se implementará en las clases derivadas para evaluar si el vehículo es adecuado para la compra.
Clases Derivadas:
*/


namespace MasEjercicicosC_
{
    abstract class Vehiculo
    {
        private string Marca { get; set; }

        private string Modelo { get; set; }

        protected int Año { get; set; }


        public Vehiculo(string unaMarca, string unModelo, int unAño) //Constructor de la clase.
        {
            this.Marca = unaMarca;
            this.Modelo = unModelo;
            this.Año = unAño;
        }

        // Metodo para mostrar detalles.

        public virtual void MostrarDetalles()
        {
            Console.WriteLine("Marca: " + Marca);

            Console.WriteLine("Modelo: " + Modelo);

            Console.WriteLine("Año: " + Año);
        }


        //Metodo para evaluar si un año es adecuado para el ingreso.

        public bool esAñoValido(int año)
        {
            return año > 1900 && año <= DateTime.Now.Year; //Date.Now.Year devuelve el año actual.  
        }   

        //Metodo abstracto para evaluar vehiculo.

        public abstract string EvaluarVehiculo();
    }
}
