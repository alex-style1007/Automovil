using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automovil_G3.clases
{
    class Automovil
    {
        public enum l_colores { Negro, Blanco, Gris, Rojo, Azul };
        //atributos
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
        //solamente los tocaran los metodos en la clase
        //EL USUARIO SOLO PODRA VERNOS
        private float nivel_tanque;
        private bool encendido = false;

        //accesores
        public string Marca
        {
            get
            {
                return marca.ToUpper();//devuelve el atributo marca
            }
            set//valido antes de escribir el atributo
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new Exception("Revise la marca que no sea nula y que tenga más de 3 caracteres");
                else
                    marca = value;//al atributo marca le llevo el valor
            }
        }

        public l_colores Color
        {
            get
            {
                return color;//devuelve el atributo marca
            }
            set//valido antes de escribir el atributo
            {
                color = value;
            }
        }
        public byte Nro_puertas
        {
            get
            {
                return nro_puertas;//devuelve el atributo marca
            }
            set//valido antes de escribir el atributo
            {
                if (value < 1 || value > 6)
                    throw new Exception("Revise el número de puertas, debe estar entre 1 y 6");
                else
                    nro_puertas = value;
            }
        }
        public ushort Max_velocidad
        {
            get
            {
                return max_velocidad;
            }
            set
            {
                if (value > 532 || value < 120)
                    throw new Exception("Revise la velocidad máxima, entre 120 y 532");
                else
                    max_velocidad = value;
            }
        }
        public ushort Cilindraje
        {
            get
            {
                return cilindraje;
            }
            set
            {
                if (value < 800 || value > 7000)
                    throw new Exception("Revise el cilindraje, entre 800 y 7000cc");
                else
                    cilindraje = value;
            }
        }
        public byte Nro_pasajeros
        {
            get
            {
                return nro_pasajeros;
            }
            set
            {
                if (value < 1 || value > 7)
                    throw new Exception("Revise el núemro de pasajeros, entre 1 y 7");
                else
                    nro_pasajeros = value;
            }
        }
        public float Largo
        {
            get
            {
                return largo;
            }
            set
            {
                if (value < 1.5f || value > 5)
                    throw new Exception("Revise el largo, entre 1.5 y 5 metros");
                else
                    largo = value;
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || modelo.Length < 1)
                    throw new Exception("Revise el modelo que no sea nula y que tenga mínimo 1 caracter");
                else
                    modelo = value;
            }

        }
        public ushort Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (value < 2000 || value > DateTime.Now.Year + 1)
                    throw new Exception("Revise el año, no debe ser menor a 2000 ni mayor a " + (DateTime.Now.Year + 1));
                else
                    ano = value;
            }
        }
        public float Peso
        {

            get
            {​​​​
              return peso;
            }​​​​
              set
            {​​​​
                 if (value < 690 || value > 5000)
                    throw new Exception("Revise el peso, no puede ser mayor que 5000kl ni menor que 690kl");
                else
                    peso = value;
            }​​​​



}​​​​
            public byte Capacidad_tanque
        {​​​​
            get
            {​​​​
             return capacidad_tanque;
            }​​​​
              set
            {​​​​
               if (value < 5 || value > 20)
                    throw new Exception("Revise la capacidad del tanque, no puede ser mayor que 20gl ni menor que 5 gl");
                else
                    capacidad_tanque = value;
            }​​​​
}​​​​
      //SOLO PUEDEN VER EL VALOR
       public float Nivel_tanque { get => nivel_tanque; }
        public bool Encendido { get => encendido; }

        public Automovil()//constructor con parametros
        {

        }
        public Automovil(string marca, l_colores color, byte nro_puertas, ushort max_velocidad,
       ushort cilindraje, byte nro_pasajeros, float largo, string modelo, ushort ano,
       float peso, byte capacidad_tanque)
        {
            Marca = marca;//el accesor recibe el parametro para validarlo
            Nro_pasajeros = nro_pasajeros;
            Color = color;
            Nro_puertas = nro_puertas;
            Max_velocidad = max_velocidad;
            Cilindraje = cilindraje;
            Largo = largo;
            Modelo = modelo;
            Ano = ano;
            Capacidad_tanque = capacidad_tanque;
            Peso = peso;
        }
        //Metodos

        public void Encender()
        {
            //enciende un vehiculo cuando esta apagado
            try
            {
                if (!encendido && nivel_tanque > 0) encendido = true;
                else
                    throw new Exception("no se puede encender por que no tiene" + "combustible");
            }
            catch (Exception)
            {
                throw new Exception("error en el metodo encender");
            }
        }
        public void Apagar()
        {
            //Apago el auto cuando esta encendido
            // (encendido) encendido equivale (encendido== true)
            // (!encendido) encendido equivale (encendido== false)


            try
            {
                if (encendido)
                    encendido = false;
                else
                    throw new Exception("el auto esta apagado");
            }
            catch (Exception)
            {
                throw new Exception("error en el metodo apagar");
            }
        }
        public void Cargar_Combustible()//llenar el tanque
                                        //1.verificar carro apagago
                                        //2. capacidad de tanque-nivel de combustible
        {
            try
            {
                if (!encendido && nivel_tanque < capacidad_tanque)
                    nivel_tanque += capacidad_tanque - nivel_tanque;
                else throw new Exception("debe de apagar el auto o el tanque esta lleno");
            }
            catch (Exception)
            {
                throw new Exception("cargar combustible");
            }
        }
        public bool Cargar_Combustible(uint Cant_dinero, uint precio_galon)
        {
            //1 auto apagado
            // 2 cant dinero y precio galon
            //3 convertir dinero en 
            // 4 nivel del tanque - nivel de combustible < galones ingresar
            //5 aumento nivel tanque en cantidad de galones que compre
            try
            {
                if (!encendido && Cant_dinero > 0 && precio_galon > 0)
                {
                    float cantidad_galones = (Cant_dinero / precio_galon);
                    if ((cantidad_galones + nivel_tanque) > capacidad_tanque)
                        throw new Exception("la cantidad de galones que estoy comprando excede" + "la capacidad del tanque");
                    else
                    {
                        nivel_tanque += cantidad_galones;
                        return true;

                    }
                }
                else
                    throw new Exception(" revisar la cantidad del dinero y el auto debe de estar apagado");
            }
            catch (Exception)
            {
                throw new Exception("error en el metodo encender");
            }
        }
        public bool Cargar_Combustible(float cantidad_galones)
        {
            //1 auto apagado
            //2 cantidad de galones a cargar sea 
            try
            {
                if (cantidad_galones > 0 && !encendido && (cantidad_galones + nivel_tanque) <= capacidad_tanque)
                {
                    nivel_tanque += cantidad_galones;
                    return true;
                }
                else
                    throw new Exception("revisar la cantidad de galones a cargar si excede la capacidad del tanque" + "o la cantidad de galones debe ser mayores a 0 y " +
                        "el auto debe de estar apagado");
            }
            catch (Exception)
            {
                throw new Exception("cargar combustible,por galones");
            }
        }

    }
}
