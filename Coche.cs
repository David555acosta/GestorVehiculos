using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Coche que tenga una propiedad adicional NumeroDePuertas (int) y evalúe si tiene un número aceptable de puertas
// (por ejemplo, entre 2 y 5).

namespace MasEjercicicosC_
{
    class Coche:Vehiculo
    {
        private int NumeroDePuertas { get; set; }


        public Coche(string unaMarca, string unModelo, int unAño, int unNumeroDePuertas) : base(unaMarca, unModelo, unAño)
        {
            this.NumeroDePuertas = unNumeroDePuertas;
        }



        //Llamo al medo mostrar Detalles , mediante el Override puede modificar a mi preferencia lo que devuelve el metodo.
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("Numero de puertas: " + NumeroDePuertas);
        }


        //Metodo para evaluar que describe si un auto tiene un numero adecuado de puertas.
        public bool esCantidadDePuertasValida (int cantidadPuertas)
        {
            return cantidadPuertas > 2 && cantidadPuertas <= 5;    
        }   




        //Metodo para evaluar si el coche es adecuado para la compra.
        //El metodo evaluar vehiculo se implementa en la clase derivada Coche , podemos modificar lo que devuelve el metodo.
        //La diferencia con el metodo mostrarDetalles es que este metodo debe estar si o si en cada clase derivada del vehiculo.
        public override string EvaluarVehiculo()
        {
            if (esCantidadDePuertasValida(NumeroDePuertas) && esAñoValido(Año)) //Condicionales abrsayendo el codigo
                                                                                //La propiedad Año es heredada de laa clase vehiculo es Protected para poder acceder a ella.
                                                                                //Si fuera private no podriamos acceder a ella. 
            {
                return "El coche es adecuado para la compra.";
            }
            else
            {
                return "El coche no es adecuado para la compra.";
            }
        }   
    }
}
