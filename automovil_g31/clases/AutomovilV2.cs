using System;

namespace automovil_G3.clases
{
    class Automovil
    {
        public enum l_colores { Negro, Blanco, Gris, Rojo, Azul }

        // Atributos
        private string marca;
        private l_colores color;
        private byte nro_puertas;
        private ushort max_velocidad;
        private ushort cilindraje;
        private byte nro_pasajeros;
        private float largo;
        private string modelo;
        private ushort ano;
        private float peso;
        private byte capacidad_tanque;

        // Solo pueden ser modificados por los métodos de la clase
        private float nivel_tanque;
        private bool encendido = false;

        // Accesores
        public string Marca
        {
            get => marca.ToUpper();
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("Revise la marca que no sea nula y que tenga más de 3 caracteres");
                marca = value;
            }
        }

        public l_colores Color
        {
            get => color;
            set => color = value;
        }

        public byte Nro_puertas
        {
            get => nro_puertas;
            set
            {
                if (value < 1 || value > 6)
                    throw new ArgumentException("Revise el número de puertas, debe estar entre 1 y 6");
                nro_puertas = value;
            }
        }

        public ushort Max_velocidad
        {
            get => max_velocidad;
            set
            {
                if (value < 120 || value > 532)
                    throw new ArgumentException("Revise la velocidad máxima, entre 120 y 532");
                max_velocidad = value;
            }
        }

        public ushort Cilindraje
        {
            get => cilindraje;
            set
            {
                if (value < 800 || value > 7000)
                    throw new ArgumentException("Revise el cilindraje, entre 800 y 7000cc");
                cilindraje = value;
            }
        }

        public byte Nro_pasajeros
        {
            get => nro_pasajeros;
            set
            {
                if (value < 1 || value > 7)
                    throw new ArgumentException("Revise el número de pasajeros, entre 1 y 7");
                nro_pasajeros = value;
            }
        }

        public float Largo
        {
            get => largo;
            set
            {
                if (value < 1.5f || value > 5f)
                    throw new ArgumentException("Revise el largo, entre 1.5 y 5 metros");
                largo = value;
            }
        }

        public string Modelo
        {
            get => modelo;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1)
                    throw new ArgumentException("Revise el modelo que no sea nulo y que tenga mínimo 1 caracter");
                modelo = value;
            }
        }

        public ushort Ano
        {
            get => ano;
            set
            {
                if (value < 2000 || value > DateTime.Now.Year + 1)
                    throw new ArgumentException($"Revise el año, no debe ser menor a 2000 ni mayor a {DateTime.Now.Year + 1}");
                ano = value;
            }
        }

        public float Peso
        {
            get => peso;
            set
            {
                if (value < 690 || value > 5000)
                    throw new ArgumentException("Revise el peso, no puede ser mayor que 5000kg ni menor que 690kg");
                peso = value;
            }
        }

        public byte Capacidad_tanque
        {
            get => capacidad_tanque;
            set
            {
                if (value < 5 || value > 20)
                    throw new ArgumentException("Revise la capacidad del tanque, no puede ser mayor que 20 galones ni menor que 5 galones");
                capacidad_tanque = value;
            }
        }

        public float Nivel_tanque => nivel_tanque;
        public bool Encendido => encendido;

        // Constructor por defecto
        public Automovil() { }

        // Constructor con parámetros
        public Automovil(string marca, l_colores color, byte nro_puertas, ushort max_velocidad, ushort cilindraje, byte nro_pasajeros, float largo, string modelo, ushort ano, float peso, byte capacidad_tanque)
        {
            Marca = marca;
            Color = color;
            Nro_puertas = nro_puertas;
            Max_velocidad = max_velocidad;
            Cilindraje = cilindraje;
            Nro_pasajeros = nro_pasajeros;
            Largo = largo;
            Modelo = modelo;
            Ano = ano;
            Peso = peso;
            Capacidad_tanque = capacidad_tanque;
        }

        // Métodos
        public void Encender()
        {
            if (!encendido && nivel_tanque > 0)
                encendido = true;
            else
                throw new InvalidOperationException("No se puede encender porque no tiene combustible");
        }

        public void Apagar()
        {
            if (encendido)
                encendido = false;
            else
                throw new InvalidOperationException("El auto está apagado");
        }

        public void Cargar_Combustible()
        {
            if (!encendido && nivel_tanque < capacidad_tanque)
                nivel_tanque = capacidad_tanque;
            else
                throw new InvalidOperationException("Debe apagar el auto o el tanque está lleno");
        }

        public bool Cargar_Combustible(uint Cant_dinero, uint precio_galon)
        {
            if (!encendido && Cant_dinero > 0 && precio_galon > 0)
            {
                float cantidad_galones = Cant_dinero / (float)precio_galon;
                if ((cantidad_galones + nivel_tanque) > capacidad_tanque)
                    throw new InvalidOperationException("La cantidad de galones que está comprando excede la capacidad del tanque");
                nivel_tanque += cantidad_galones;
                return true;
            }
            throw new InvalidOperationException("Revise la cantidad del dinero y que el auto esté apagado");
        }

        public bool Cargar_Combustible(float cantidad_galones)
        {
            if (cantidad_galones > 0 && !encendido && (cantidad_galones + nivel_tanque) <= capacidad_tanque)
            {
                nivel_tanque += cantidad_galones;
                return true;
            }
            throw new InvalidOperationException("Revise la cantidad de galones a cargar si excede la capacidad del tanque o el auto debe estar apagado");
        }
    }
}
