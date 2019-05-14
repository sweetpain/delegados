using System;
using System.Linq;
using System.Collections.Generic;

namespace Delegados
{
    class Program
    {


        static void Main(string[] args)
        {
            /************11111***********/
            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var guardar = proyectolis.Where(x => x.Codigo > 6 && x.Codigo < 12).ToList();
            //pro.ShowList(guardar);
            //Console.ReadLine();

            /***********22222************/



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Segundo ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Search = from p in proyectolis
            //             where (p.Nombre.StartsWith("B"))
            //             select p;
            //pro.ShowList(Search.ToList());
            //Console.ReadLine();

            /***********33333************/

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Tercer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Multi = proyectolis.Where(x => x.Codigo % 7 ==0).ToList();
            //pro.ShowList(Multi);
            //Console.ReadLine();

            /***********4444************/

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Superior = proyectolis.GroupBy(x =>
            //{
            //    if (x.Duracion<=6)
            //    {
            //        return "Duracion inferior a 6";

            //    }
            //    else if (x.Duracion >= 7 && x.Duracion < 11)
            //    {
            //        return "Duracion entre 7 y 10";

            //    }
            //    else
            //    {
            //        return "Salio";

            //    }


            //});

            //foreach (var Proyectosbase in Superior)
            //{

            //    Console.WriteLine("Grupo de proyectos"+Proyectosbase.Key +"  Hay  "+ Proyectosbase.Count());
            //    foreach (var item in Proyectosbase)
            //    {

            //        Console.WriteLine($"Nombre del proyecto:{item.Nombre} ");
            //        Console.WriteLine($"Codigo:{item.Codigo} ");
            //        Console.WriteLine($"Codigo:{item.Duracion} ");
            //    }

            //}

            //Console.ReadLine();


            /***********5555555************/



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Quinto ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Promedio = proyectolis.Average(x => x.Codigo);
            //Console.WriteLine($"Su promedio es: {Promedio}");
            //Console.ReadLine();



            /***********5555555************/


            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Sexto ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;

            //var dato = proyectolis.Max(y => y.Duracion);
            //var mayor = proyectolis.Where(x => x.Duracion==dato).Select(x => x.Nombre).FirstOrDefault();

            //Console.WriteLine($"el nombre del proyecto con maxima duracion es :  {mayor}");
            //Console.ReadLine();



            /*******777777777************/



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Septimo ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var NombreArea = proyectolis.Where(x => x.Duracion > 6).Select(x =>
            //   new Proyecto()
            //   {
            //       Nombre = x.Nombre,
            //       Area = x.Area

            //   }

            //).ToList();
            //pro.ShowList(NombreArea);

            //Console.ReadLine();

            /*******8888888************/

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var guardar = proyectolis.Any(x => x.Duracion > 24);
            //Console.WriteLine($"{guardar}");
            //Console.ReadLine();

            /*******99999999************/

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var sum = proyectolis.Where(x => x.Codigo > 20).Sum(x => x.Duracion);
            //Console.WriteLine($"{sum}");
            //Console.ReadLine();

            /*******100000************/

            



        }


    }
}
