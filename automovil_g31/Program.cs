using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automovil_G3.clases;

namespace automovil_G3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                /*
                 //instancia nuestro primer automovil
                 Automovil mi_automovil = new Automovil();
                 //le pongo datos a los accesores para que los validen y los entreguen al atributo
                 mi_automovil.Marca = "Mitsubishi";
                 mi_automovil.Color = Automovil.l_colores.Gris;
                 mi_automovil.Nro_puertas = 15;
                 mi_automovil.Max_velocidad = 220;
                 mi_automovil.Cilindraje = 2500;
                 mi_automovil.Nro_pasajeros = 7;
                 mi_automovil.Largo = 4;
                 mi_automovil.Modelo = "Outlander";
                 mi_automovil.Ano = 2014;
                 mi_automovil.Peso = 1.7f;
                 mi_automovil.Capacidad_tanque = 14;


                 Console.WriteLine("la marca de mi carro es:" + mi_automovil.Marca + "el cilindraje es:" + mi_automovil.Cilindraje + "esta encendido?"
                     + mi_automovil.Encendido);
                 mi_automovil.Cargar_Combustible();
                 mi_automovil.Encender();



                 Automovil homero_movil = new Automovil("audi", Automovil.l_colores.Blanco, 2, 180, 4500, 2, 2.5f, "q7", 2001, 1, 8, 10);
                */

                //creamos un objeto automovil para llenar la lista automoviles
                Automovil obj_Auto;
                //CREAMOS UN OBJETO PERSONA
                Persona CR7 = new Persona("Cristiano ronaldo", "5658552");

                //crear automovil nuevo
                obj_Auto = new Automovil("lamborghini", Automovil.l_colores.Negro, 2, 350, 6500, 2, 4.7f, "AVENTADOR", 2020, 1600, 18);
                //adiccionemos el carro a la lista

                CR7.L_automoviles.Add(obj_Auto);

                //Vamos a crear otro automovil
                obj_Auto = new Automovil("RANGE ROVER", Automovil.l_colores.Gris, 5, 300, 3600, 5, 4.8f, "sport", 2019, 2800, 20);
                CR7.L_automoviles.Add(obj_Auto);

                //recorrer la lista
                Console.WriteLine("LISTA DE CARROS DE " + CR7);
                foreach (Automovil elementos in CR7.L_automoviles)
                {
                    Console.WriteLine(elementos.Marca + "" + elementos.Modelo);
                }
                //segundo cronstuctro, lista pa j balvin
                //lo primero es crear la lista

                List<Automovil> l_automoviles_ppal = new List<Automovil>();

                //vamos a crear 2 automoviles
                obj_Auto = new Automovil("ferrari", Automovil.l_colores.Rojo, 2, 325, 4500, 2, 4.5f, "458 speciale", 2019, 1370, 18);
                l_automoviles_ppal.Add(obj_Auto);

                obj_Auto = new Automovil("mercedez benz", Automovil.l_colores.Blanco, 5, 220, 3982, 5, 4.8f, "AMG 63", 2020, 2560, 20);
                l_automoviles_ppal.Add(obj_Auto);

                //crear un objeto jbalvin

                Persona jbalvin = new Persona("jbalvin", "564823", l_automoviles_ppal);

                Console.WriteLine("\nla lista de autos de" + jbalvin.Nombre + "son:");
                foreach (Automovil elementos in jbalvin.L_automoviles)
                {
                    Console.WriteLine(elementos.Marca + "" + elementos.Modelo);

                }





            }
            catch (Exception error)
            {
                Console.WriteLine("ocurrio un error" + error);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("termino la ejecucion");
                Console.ReadKey();
            }
        }

        private static float Random()
        {
            throw new NotImplementedException();
        }
    }
}
