using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1
{
    internal class Persona
    {
        public string Nombre;
        public string Apellido;
        public int edad;
        public string op;


        public void Ingresar()
        {
            try
            {
                Console.WriteLine("Ingrese sus datos:");
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese su nombre");
                Nombre = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su apellido");
                Apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su edad");
                edad = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}
