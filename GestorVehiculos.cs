using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Crea una clase GestorVehiculos que contenga:
Una lista de tipo List<Vehiculo> para almacenar los vehículos.
Un método AgregarVehiculo(Vehiculo vehiculo) para agregar vehículos a la lista.
Un método MostrarVehiculos() que recorra la lista y llame al método MostrarDetalles() de cada vehículo.
Un método EvaluarVehiculos() que llame al método EvaluarVehiculo() de cada vehículo y muestre los resultados.
Interacción con el Usuario:
*/

namespace MasEjercicicosC_
{
    internal class GestorVehiculos
    {
        public List<Vehiculo> vehiculos = new List<Vehiculo>();



        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            //Agregamos el vehiculo a la lista si cumple con estas condiciones
            //Mediante el metodo BuscarEnLista() verificamos si el vehiculo ya se encuentra en la lista.
            if (BuscarEnLaLista(vehiculo) == null)
            {
                vehiculos.Add(vehiculo);
            }
            else
            {
                Console.WriteLine("El vehiculo ya se encuentra en la lista.");
            }
        }


        //Este metodo recorre los elementos de la la lista vehiculo y retorna el vehiculo cuando se encuente *vehiculoAbuscar* y
        //null cuando no encuentra nada
        public Vehiculo BuscarEnLaLista(Vehiculo vehiculoABuscar)
        {
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculoABuscar == vehiculo) 
                {
                    return vehiculo;
                }
            }
            return null;
        }


        //Metodo para mostrar los detalles de cada vehiculo de la lista de vehiculos.
        public void MostrarVehiculos()
        {
            foreach (var vehiculo in vehiculos)
            {
                vehiculo.MostrarDetalles();
            }
        }


        //Metodo para evaluar cada vehiculo de la lista de vehiculos que funciona llamando al metodo EvaluarVehiculo() de cada vehiculo.

        public void EvaluarVehiculos()
        {
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.EvaluarVehiculo());
            }
        }
    }

}
