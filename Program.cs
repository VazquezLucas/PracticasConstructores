using System;

namespace PracticasConstructores
{
    class program
    {
        static void Main(string[] args)
        {

            Coche coche1 = new Coche();

            Coche coche2 = new Coche();

            Coche coche3 = new Coche(4500.25,1200.35); 

            Console.WriteLine(coche2.getInfoCoche());

            Console.WriteLine(coche1.getInfoCoche());

            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero");

            Console.WriteLine(coche3.getExtras());
        }
    }
    
    
    //-----------------------------------------------------------------------------------------------------------


    partial class Coche
    {
        public Coche()
        {

            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            tapiceria = "tela";

        }

        public Coche(double largoCoche, double anchoCoche)
        {

            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;

            tapiceria = "tela";

        }
    }
    partial class Coche
    {
        public String getInfoCoche()
        {
           
            return "Informacion del coche:\n" + "Ruedas:" + ruedas + " Largo:"+ largo + " Ancho:" + ancho;

        }

        public void setExtras(bool climatizador, String tapiceria)
        {

            this.climatizador = climatizador;

            this.tapiceria = tapiceria;

        }

        public String getExtras()
        {

            return "Extras del coche: \n" + "tapiceria:" + tapiceria + " Climatizador:" + climatizador;

        }


        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;

    }
    //-----------------------------------------------------------------------------------------------------------
}