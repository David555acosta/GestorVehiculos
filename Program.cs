using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasEjercicicosC_
{

    /*
     Clases Base y Derivadas:

Crea una clase base llamada Vehiculo con propiedades privadas:
Marca (string)
Modelo (string)
Año (int)
Agrega un método virtual MostrarDetalles() que muestre la información del vehículo.
Agrega un método abstracto EvaluarVehiculo() que se implementará en las clases derivadas para evaluar si el vehículo es adecuado para la compra.
Clases Derivadas:

Crea dos clases derivadas:
Coche que tenga una propiedad adicional NumeroDePuertas (int) y evalúe si tiene un número aceptable de puertas (por ejemplo, entre 2 y 5).
Motocicleta que tenga una propiedad adicional Cilindrada (int) y evalúe si la cilindrada es adecuada (por ejemplo, mayor a 0).
Gestor de Vehículos:

Crea una clase GestorVehiculos que contenga:
Una lista de tipo List<Vehiculo> para almacenar los vehículos.
Un método AgregarVehiculo(Vehiculo vehiculo) para agregar vehículos a la lista.
Un método MostrarVehiculos() que recorra la lista y llame al método MostrarDetalles() de cada vehículo.
Un método EvaluarVehiculos() que llame al método EvaluarVehiculo() de cada vehículo y muestre los resultados.
Interacción con el Usuario:

En el método Main, solicita al usuario que ingrese los datos de los vehículos mediante Console.ReadLine().
Permite al usuario ingresar múltiples vehículos hasta que decida detenerse.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            GestorVehiculos gestor = new GestorVehiculos();

            string continuar;

            //Primero pregunta y luego ejecuta las condiciones del while , asi primeramente tomamos como referencia los datos ingresados por el usuario.
            do
            {
                Console.WriteLine("Ingrese el tipo de vehiculo que desea agregar:");
                Console.WriteLine("Ingrese tipo:");
                string tipoVehiculo = Console.ReadLine().ToLower(); // el metodo ToLower convierte todos los strings ingresados a minusculas.

                Console.WriteLine("Ingrese la marca del vehiculo:");
                string marcaVehiculo = Console.ReadLine();

                Console.WriteLine("Ingrese modelo del vehiculo");
                string modeloVehiculo = Console.ReadLine();

                Console.WriteLine("Ingrese el año del vehiculo:");
                int añoVehiculo = int.Parse(Console.ReadLine());    


                if (tipoVehiculo == "coche") // si el tipo de vehiculo es igual a coche se ejecuta esta condicion ,
                                             //asi se ingrese COCHE , lo leera como coche gracias al metodo ToLower.   
                {
                    Console.WriteLine("Ingrese numero de pueras");

                    int numeroDePuertas = int.Parse(Console.ReadLine());    
                    
                    Coche coche = new Coche (tipoVehiculo , modeloVehiculo, añoVehiculo, numeroDePuertas); //Los datos ingresados se pasan como argumentos al constructor de la clase Coche.    

                    gestor.AgregarVehiculo(coche);

                } else if (tipoVehiculo == "motocicleta")// si el tipo de vehiculo es igual a motocicleta se ejecuta esta condicion ,
                                                         //asi se ingrese MOTOCICLETA , lo leera como motocicleta gracias al metodo ToLower.   
                {
                    Console.WriteLine("Ingrese cilindrada");
                    int cilindradaAutoActual = int.Parse(Console.ReadLine());

                    Motocicleta motoNueva = new Motocicleta(tipoVehiculo, modeloVehiculo, añoVehiculo, cilindradaAutoActual);

                    //Los datos ingresados se pasan como argumentos al constructor de la clase Coche.

                    gestor.AgregarVehiculo(motoNueva); 

                } else
                {
                    Console.WriteLine("Vehiculo no valido");
                }


                Console.WriteLine("¿Desea agregar otro vehículo? (s/n):");
                continuar = Console.ReadLine();

            } while (continuar.ToLower() == "s"); // Variable para evaluar si el usuario desea continuar ingresando vehiculos.


            //Al salir del ciclo while se muestran en consola el muestran los vehiculos del gestor.

            Console.WriteLine("Lista de vehiculos:");
            gestor.MostrarVehiculos();

            //Tambien se muestra una evaluacion sobre cada vehiculo ingresado.
            Console.WriteLine("Evaluacion de vehiculos:");
            gestor.EvaluarVehiculos();
        }
    }
}


//Al realizarlo de esta forma manual el ingreso de datos no se genera ningun conflico , el conflicto es generado en el ciclo while aunque 2 clases sean iguales las agrega igual
//A correjir.

/*
 internal class Program
    {
        static void Main(string[] args)
        {
            GestorVehiculos gestor = new GestorVehiculos();

            Coche cocheReno = new Coche("Renault", "Clio", 2010, 4);

            gestor.AgregarVehiculo(cocheReno);
            gestor.AgregarVehiculo(cocheReno);

            gestor.MostrarVehiculos();
        }

    }
*/
