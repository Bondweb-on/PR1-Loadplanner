using System;

namespace PR1_Loadplanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Objetos objeto1 = new Objetos("Barril", "B", 2, 1, 70f);
            Objetos objeto2 = new Objetos("Bolsa de chatarra", "BC", 1, 1, 20f);
            Objetos objeto3 = new Objetos("Bolsa con plantas", "BP", 2, 1, 3f);
            Objetos objeto4 = new Objetos("Caja ligera", "C1", 1, 1, 5f);
            Objetos objeto5 = new Objetos("Caja pesada", "C2", 1, 1, 15f);
            Objetos objeto6 = new Objetos("Caja vacía", "C3", 1, 1, 0.2f);
            Objetos objeto7 = new Objetos("Silla", "S", 2, 1, 4f);
            Objetos casillaNula = new Objetos(null, "X", 0, 0, 0f);
            
            Objetos [,] loadPlanner = new Objetos [3,4] {{casillaNula, objeto4, objeto6, casillaNula},
                                                         {objeto1, objeto5, objeto7, objeto3}, 
                                                         {objeto1, objeto2, objeto7, objeto3}};
                        
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(loadPlanner[i,j].abreviacion + " ");
                }
                Console.WriteLine();
            }

            if((loadPlanner[0,1].peso > loadPlanner[1,1].peso))
            {
                Console.WriteLine(loadPlanner[1,1].nombre + " se esta aplastando");
            }
            else if((loadPlanner[1,1].peso > loadPlanner[2,1].peso))
            {
                Console.WriteLine(loadPlanner[2,1].nombre + "Se esta aplastando");
            }
            else if((loadPlanner[0,2].peso > loadPlanner[1,2].peso))
            {
                Console.WriteLine(loadPlanner[1,2].nombre + " se esta aplastando");
            }
            else if((loadPlanner[1,2].peso > loadPlanner[2,2].peso))
            {
                Console.WriteLine(loadPlanner[2,2].nombre + " se esta aplastando");
            }
            else if((loadPlanner[1,0].peso > loadPlanner[2,0].peso))
            {
                Console.WriteLine(loadPlanner[2,0].nombre + " se esta aplastando");
            }
            else if((loadPlanner[1,3].peso > loadPlanner[2,3].peso))
            {
                Console.WriteLine(loadPlanner[2,3].nombre + " se esta aplastando");
            }
            else if((loadPlanner[0,1].peso <= loadPlanner[1,1].peso && loadPlanner[1,1].peso <= loadPlanner[2,1].peso))
            {
                Console.WriteLine("Nada se esta aplastando.");
            }
            else if((loadPlanner[0,2].peso <= loadPlanner[1,2].peso && loadPlanner[1,2].peso <= loadPlanner[2,2].peso))
            {
                Console.WriteLine("Nada se esta aplastando.");
            }
            else if((loadPlanner[1,0].peso <= loadPlanner[2,0].peso && loadPlanner[1,3].peso <= loadPlanner[2,3].peso))
            {
                Console.WriteLine("Nada se esta aplastando.");
            }


        }
    }
}
