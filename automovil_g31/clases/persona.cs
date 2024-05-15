using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automovil_G3.clases
{
    class Persona
    {
        private string nombre;
        private string id;
        private List<Automovil> l_automoviles; // Implementación de la relación

        // Constructor 1: Va a pedir nombre e id y crea lista en blanco
        public Persona(string nombre, string id)
        {
            Nombre = nombre;
            Id = id;
            // Creación lista vacía
            l_automoviles = new List<Automovil>();
        }

        // Constructor 2: Va a pedir nombre, id y lista de automóviles
        public Persona(string nombre, string id, List<Automovil> l_automoviles)
        {
            Nombre = nombre;
            Id = id;
            L_automoviles = l_automoviles;
        }

        public string Nombre
        {
            get => nombre.ToUpper();
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new Exception("Revise que el nombre tenga más de 6 caracteres y no sea nulo o vacío.");
                else
                    nombre = value;
            }
        }

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new Exception("Revise que el ID tenga más de 6 caracteres y no sea nulo o vacío. No se pudo crear el objeto.");
                else
                    id = value;
            }
        }

        internal List<Automovil> L_automoviles
        {
            get => l_automoviles;
            set => l_automoviles = value;
        }

        // Método para añadir un automóvil a la lista
        public void AgregarAutomovil(Automovil automovil)
        {
            if (automovil == null)
                throw new Exception("El automóvil no puede ser nulo.");
            l_automoviles.Add(automovil);
        }

        // Método para eliminar un automóvil de la lista por objeto
        public void EliminarAutomovil(Automovil automovil)
        {
            if (!l_automoviles.Remove(automovil))
                throw new Exception("El automóvil no se encuentra en la lista.");
        }

        // Método para eliminar un automóvil de la lista por índice
        public void EliminarAutomovil(int index)
        {
            if (index < 0 || index >= l_automoviles.Count)
                throw new Exception("Índice fuera de rango.");
            l_automoviles.RemoveAt(index);
        }

        // Método para mostrar información de todos los automóviles
        public void MostrarAutomoviles()
        {
            if (l_automoviles.Count == 0)
            {
                Console.WriteLine("La persona no tiene automóviles.");
                return;
            }

            Console.WriteLine("Automóviles de " + Nombre + ":");
            foreach (var auto in l_automoviles)
            {
                Console.WriteLine($"- Marca: {auto.Marca}, Modelo: {auto.Modelo}, Año: {auto.Ano}");
            }
        }
    }
}
