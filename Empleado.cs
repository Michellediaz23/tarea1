using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Empleado
    {
        // iniciamos primeramente declarando las variables miebro de la clase como datos del empleador
        private string nombre;
        private int numeroEmpleado;
        private double salario;
        private bool activo; // estado del empleado( activo o inactivo);



        //constructor para inicializar la clase empleado
        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = (double)salario;
            this.activo = activo;
        }



        public void MostrarDetalles ()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de empleado: {numeroEmpleado}, salario: {salario:c}, Estado:{estado}");

            // metodo para mostrar los detaalles del empleador en la consola

        }
        
        public double ObtenernumeroEmpleado()
        {
            return this.numeroEmpleado;

            //Metodo para cambiar el numero del emplead

        }



        // metodo  que permite hacer que cambie el estado de un empleado a activo o desactivado y se encarga
        // cambiar el estado de un empleado  segun el valor proporcionado
        public void cambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true;
                Console.WriteLine("Empleado activo");

            }
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("Empleado desactivado");

            }
            else
            {
                Console.WriteLine("estado no valido");

            }
            
            
        }

    }
}