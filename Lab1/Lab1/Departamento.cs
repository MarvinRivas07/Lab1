using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Departamento
    {
        public string tipo;
        public string muni;
        public void seleccionarDepartamento()
        {
           Municipio muni = new Municipio();
            Console.WriteLine("Seleccione el departamento al que pertenezca: \n1-Chalatenango \n2-San Salvador \n3-San Miguel \n4-Santa Ana \n5-Usulutan \n6-Cabañas \n7-La Libertad \n8-La Paz \n9-Cuscatlan \n10-San Vicente \n11-Morazan \n12-Ahuachapan \n13-La Union \n14-Sonsonate");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Chalatenango";
                    muni.Chalatenango();
                    break;
                case 2:
                    tipo = "San Salvador";
                    muni.SanSalvador();
                    break;
                case 3:
                    tipo = "San Miguel";
                    muni.SanMiguel();
                    break;
                case 4:
                    tipo = "Santa Ana";
                    muni.santaAna();
                    break;
                case 5:
                    tipo = "Usulutan";
                    muni.Usulutan();
                    break;
                case 6:
                    tipo = "Cabañas";
                    muni.Cabana();
                    break;
                case 7:
                    tipo = "La Libertad";
                    break;
                case 8:
                    tipo = "La Paz";
                    break;
                case 9:
                    tipo = "Cuscatlan";
                    break;
                case 10:
                    tipo = "San Vicente";
                    break;
                case 11:
                    tipo = "Morazan";
                    break;
                case 12:
                    tipo = "Ahuachapan";
                    break;
                case 13:
                    tipo = "La Union";
                    break;
                case 14:
                    tipo = "Sonsonate";
                    break;
                default:
                    break;
            }
        }
    }
}
