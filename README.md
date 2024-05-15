
# Ejercicio de POO en C# con clases Automovil y Usuario
* Contexto:

Imagina un sistema de gestión de alquiler de autos. En este sistema, necesitamos almacenar información sobre los autos disponibles y los usuarios que los alquilan. Para ello, podemos crear dos clases: Automovil y Usuario.

## Clase Automovil:
La clase Automovil representará cada uno de los autos disponibles para alquiler. Deberia  tener atributos como:

* marca: La marca del auto (por ejemplo, Toyota, Chevrolet, etc.)
* modelo: El modelo del auto (por ejemplo, Corolla, Aveo, etc.)
* año: El año de fabricación del auto
* color: El color del auto
* placa: La placa del auto
* estado: El estado actual del auto (disponible, alquilado, en mantenimiento, etc.)
* precio_alquiler: El precio diario de alquiler del auto
## Clase Usuario:
La clase Usuario representará a cada uno de los clientes que alquilan los autos. Deberá tener atributos como:

* nombre: El nombre completo del usuario
* cedula: El número de cédula de identidad del usuario
* direccion: La dirección del usuario
* telefono: El número de teléfono del usuario
* autos_alquilados: Una lista de los autos que el usuario ha alquilado en el pasado
* Relación entre las clases:

Las clases Automovil y Usuario se relacionan entre sí de una manera uno a muchos. Un auto puede ser alquilado por varios usuarios, pero un usuario solo puede alquilar un auto a la vez.

# Operaciones:

El sistema deberia permitir realizar las siguientes operaciones:

* Agregar un nuevo auto: Esta operación permitirá al administrador del sistema agregar un nuevo auto a la flota disponible.
* Eliminar un auto: Esta operación permitirá al administrador del sistema eliminar un auto de la flota disponible.
* Consultar autos disponibles: Esta operación permitirá al usuario ver la lista de autos disponibles para alquiler.
* Alquilar un auto: Esta operación permitirá al usuario alquilar un auto disponible.
* Devolver un auto: Esta operación permitirá al usuario devolver un auto alquilado.
* Consultar historial de alquileres: Esta operación permitirá al usuario ver el historial de autos que ha alquilado en el pasado.
