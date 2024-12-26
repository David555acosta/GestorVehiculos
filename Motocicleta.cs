using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasEjercicicosC_
{
     class Motocicleta:Vehiculo
    {
        private int Cilindrada { get; set; }


        public Motocicleta(string unaMarca , string unModelo , int unAño , int unaCilindrada) : base(unaMarca , unModelo , unAño)
        {
            this.Cilindrada = unaCilindrada;
        }



        //Llamo al medo mostrar Detalles , mediante el Override puede modificar a mi preferencia lo que devuelve el metodo.
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("La cilindrada es de: " + Cilindrada);
        }

        //Modifico lo que devuelve el metodo EvaluarVehiculo este metodo se implementa en la clase derivada Motocicleta.
        //Este metodo debe ser llamado si o si y debe ser implementado segun las preferencias de la clase.
        public override string EvaluarVehiculo()
        {
            if (Cilindrada > 200 && esAñoValido(Año)) //Condicionales abrsayendo el codigo
                                                      //La propiedad Año es heredada de laa clase vehiculo es Protected para poder acceder a ella.
                                                      //Si fuera private no podriamos acceder a ella. 
            {
                return "la Motocicleta es adecuada para la compra.";
            }
            else
            {
                return "La motocicleta no es adecuada para la compra.";
            }
        }
    }
}
