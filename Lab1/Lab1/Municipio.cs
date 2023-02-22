using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Municipio
    {
        public string tipo;
        public void Chalatenango()
        {
            Console.WriteLine("Seleccione el municipio \n1-San Rafael \n2-La Nueva \n3-Arcatao \n4-Potonico \n5-La Palma \n6-El Paraiso");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "San Rafael";
                    break;
                case 2:
                    tipo = "La Nueva";
                    break;
                case 3:
                    tipo = "Arcatao";
                    break;
                case 4:
                    tipo = "Potonico";
                    break;
                case 5:
                    tipo = "La Palma";
                    break;
                case 6:
                    tipo = "El Paraiso";
                    break;
                default:
                    break;
            }
        }
        public void SanSalvador()
        {
            Console.WriteLine("Seleccione el municipio \n1-Apopa \n2-Mejicanos \n3-Santo Tomas \n4-Panchimalco \n5-Aguilares \n6-El Paisnal");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Apopa";
                    break;
                case 2:
                    tipo = "Mejicanos";
                    break;
                case 3:
                    tipo = "Santo Tomas";
                    break;
                case 4:
                    tipo = "Panchimalco";
                    break;
                case 5:
                    tipo = "Aguilares";
                    break;
                case 6:
                    tipo = "El Paisnal";
                    break;
                default:
                    break;
            }
        }
        public void SanMiguel()
        {
            Console.WriteLine("Seleccione el municipio \n1-Chinameca \n2-San Rafael \n3-El Transito \n4-Chapeltique \n5-San Antonio \n6-Ciudad Barrios");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Chinameca";
                    break;
                case 2:
                    tipo = "San Rafael";
                    break;
                case 3:
                    tipo = "El Transito";
                    break;
                case 4:
                    tipo = "Chapeltique";
                    break;
                case 5:
                    tipo = "San Antonio";
                    break;
                case 6:
                    tipo = "Ciudad Barrios";
                    break;
                default:
                    break;
            }
        }
        public void santaAna()
        {
            Console.WriteLine("Seleccione el municipio \n1-El Congo \n2-Metapan \n3-Coatepeque \n4-Chalchuapa \n5-Masahuat \n6-El Porvenir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "El Congo";
                    break;
                case 2:
                    tipo = "Metapan";
                    break;
                case 3:
                    tipo = "Coatepeque";
                    break;
                case 4:
                    tipo = "Chalchuapa";
                    break;
                case 5:
                    tipo = "Masahuat";
                    break;
                case 6:
                    tipo = "El Porvenir";
                    break;
                default:
                    break;
            }
        }
        public void Usulutan()
        {
            Console.WriteLine("Seleccione el municipio \n1-Berlin \n2-Tecapan \n3-El Triunfo \n4-Nueva Granada \n5-Jiquilisco \n6-Jucuapa");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Berlin";
                    break;
                case 2:
                    tipo = "Tecapan";
                    break;
                case 3:
                    tipo = "El Triunfo";
                    break;
                case 4:
                    tipo = "Nueva Granada";
                    break;
                case 5:
                    tipo = "Jiquilisco";
                    break;
                case 6:
                    tipo = "Jucuapa";
                    break;
                default:
                    break;
            }
        }
        public void Cabana()
        {
            Console.WriteLine("Seleccione el municipio \n1-Sensuntepeque \n2-Ilobasco \n3-San Isidro \n4-Victoria \n5-Dolores \n6-Cinquera");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Sensuntepeque";
                    break;
                case 2:
                    tipo = "Ilobasco";
                    break;
                case 3:
                    tipo = "San Isidro";
                    break;
                case 4:
                    tipo = "Victoria";
                    break;
                case 5:
                    tipo = "Dolores";
                    break;
                case 6:
                    tipo = "Cinquera";
                    break;
                default:
                    break;
            }
        }
    }
}
