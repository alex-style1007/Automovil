using System;
using System.Collections.Generic;
using automovil_G3.clases;

namespace automovil_G3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear algunos objetos de Automovil
            Automovil auto1 = new Automovil("Toyota", Automovil.l_colores.Rojo, 4, 180, 2000, 5, 4.2f, "Corolla", 2020, 1500, 16);
            Automovil auto2 = new Automovil("Honda", Automovil.l_colores.Azul, 4, 200, 2500, 5, 4.4f, "Civic", 2021, 1600, 18);

            // Crear una persona y agregar los automóviles
            Persona persona1 = new Persona("Juan Pérez", "123456");
            persona1.AgregarAutomovil(auto1);
            persona1.AgregarAutomovil(auto2);

            // Mostrar los automóviles de la persona
            persona1.MostrarAutomoviles();

            // Crear otra persona con una lista inicial de automóviles
            List<Automovil> listaAutos = new List<Automovil> { auto1 };
            Persona persona2 = new Persona("Ana Gómez", "654321", listaAutos);

            // Mostrar los automóviles de la segunda persona
            persona2.MostrarAutomoviles();

            // Eliminar un automóvil de la segunda persona
            persona2.EliminarAutomovil(auto1);

            // Intentar mostrar los automóviles después de eliminar
            persona2.MostrarAutomoviles();

            // Llamar a otros métodos del automóvil
            try
            {
                auto1.Encender();
                Console.WriteLine($"El automóvil {auto1.Marca} está encendido: {auto1.Encendido}");
                auto1.Apagar();
                Console.WriteLine($"El automóvil {auto1.Marca} está encendido: {auto1.Encendido}");
                auto1.Cargar_Combustible(20, 3);
                Console.WriteLine($"El nivel del tanque del {auto1.Marca} es: {auto1.Nivel_tanque} galones");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
