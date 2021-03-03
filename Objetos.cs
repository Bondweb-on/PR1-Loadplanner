using System;

namespace PR1_Loadplanner
{
    class Objetos
    {       
        public int altura; //espacios

        public int ancho; //espacios
        public float peso; //kg
        public string abreviacion;
        public string nombre;

        // Método constructor
        public Objetos(string nombre, string abreviacion, int altura, int ancho, float peso)
        {       
            this.abreviacion = abreviacion;

            this.nombre = nombre;

            this.altura = altura;

            this.ancho = ancho;

            this.peso = peso;
        }

        private string ObtenerAbreviaturaAMostrar()
        {
            string abreviaturaAMostrar;
            if(this.abreviacion != null)
            {
                //Sí hay un nombre definido
                abreviaturaAMostrar = this.abreviacion;
            }
            else
            {
                abreviaturaAMostrar = "Tacha";
            }
            return abreviaturaAMostrar;
        }
    }
}