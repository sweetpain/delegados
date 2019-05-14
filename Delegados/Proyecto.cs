using System;
using System.Collections.Generic;
using System.Text;

namespace Delegados
{
    class Proyecto
    {
        public List<Proyecto> proyectosList = new List<Proyecto>();
        public string Nombre { get; set; }
        public double  Codigo   { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        //public List<Proyecto> AddProyect()
        //{

        //    Console.WriteLine("Digita 1 si quieres ingresar un Proyeto");
        //    var result = Convert.ToInt32(Console.ReadLine());
        //    while (result == 1)
        //    {
        //        Console.WriteLine("Escriba su Proyeto");
        //        var name = Console.ReadLine();
        //        Console.WriteLine("Escriba el codigo de su Proyeto");
        //        var code = Console.ReadLine();
        //        var myProyect = new Proyecto()
        //        {
        //            Nombre = name,
        //            Codigo = int.Parse(code)
        //        };
        //        proyectosList.Add(myProyect);
        //        Console.WriteLine("Digita 1 si quieres ingresar un Proyeto");
        //        result = Convert.ToInt32(Console.ReadLine());

        //    }
           
        //    return proyectosList;
        //}
        public List<Proyecto> AddProyect2()
        {
            var myProyect2 = new List<Proyecto>()
            {
                new Proyecto()
                {
                    Nombre="Comercial",
                    Codigo=30,
                    Area="Internacional",
                    Duracion= 7
                },
                new Proyecto()
                {
                    Nombre="Gerencia",
                    Codigo=21,
                    Area="Bancaria",
                    Duracion= 12
                },
                new Proyecto()
                {
                    Nombre="Produccion",
                    Codigo=30,
                    Area="Agricola",
                    Duracion= 8
                },
                  new Proyecto()
                {
                    Nombre="Geografia",
                    Codigo=10,
                    Area="Unica",
                    Duracion= 25
                },
                      new Proyecto()
                {
                    Nombre="Bancaria",
                    Codigo=21,
                    Area="Unica",
                    Duracion= 2
                }

        };
            proyectosList = myProyect2;
            return proyectosList;

        }
        public void ShowList(List<Proyecto> uno)
        {
            foreach (var item in uno)
            {
                Console.WriteLine($"Nombre:{item.Nombre} ");
                Console.WriteLine($"Area:{item.Area} ");


            }
        }
    }
}
