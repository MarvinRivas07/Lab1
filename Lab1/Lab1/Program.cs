using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    
    internal class Program
    {
        public string op;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos \n");
            Console.WriteLine("Opciones\n1-Ingresar datos  \n2-Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("Bienvenido");
                    Persona persona = new Persona();
                    persona.Ingresar();
                    Departamento depto = new Departamento();
                    depto.seleccionarDepartamento();
                    Console.WriteLine(persona.mostrarPersona());
                    
                    break;
                default:
                    Console.WriteLine("Lo siento");
                    break;
            }
        }
    }
}
