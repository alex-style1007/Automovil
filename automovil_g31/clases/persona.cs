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
        private List<Automovil> l_automoviles;//implementacion de la relacion

        //constructor 1: va a pedir nombre y id y crea lista en blanco

        public Persona(string nombre, string id)
        {
            Nombre = nombre;
            Id = id;
            //creacion lista vacia
            l_automoviles = new List<Automovil>();

        }
        //constructor 2:va a pedir nombre,id y lista
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
                    throw new Exception("revise que tenga mas de" + "6 caracteres o no sea espacio nulo");


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
                    throw new Exception("revise que el ID tenga mas de" + "6 caracteres o no sea espacio nulo.No se pudo rear el objeto");

                else
                    id = value;
            }
        }
        internal List<Automovil> L_automoviles { get => l_automoviles; set => l_automoviles = value; }
    }
}