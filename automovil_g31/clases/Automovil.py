class Automovil:
    class Colores:
        NEGRO = "Negro"
        BLANCO = "Blanco"
        GRIS = "Gris"
        ROJO = "Rojo"
        AZUL = "Azul"

    def __init__(self, marca=None, color=None, nro_puertas=None, max_velocidad=None,
                 cilindraje=None, nro_pasajeros=None, largo=None, modelo=None,
                 ano=None, peso=None, capacidad_tanque=None):
        self._marca = None
        self._color = None
        self._nro_puertas = None
        self._max_velocidad = None
        self._cilindraje = None
        self._nro_pasajeros = None
        self._largo = None
        self._modelo = None
        self._ano = None
        self._peso = None
        self._capacidad_tanque = None
        self._nivel_tanque = 0
        self._encendido = False

        if marca:
            self.marca = marca
        if color:
            self.color = color
        if nro_puertas:
            self.nro_puertas = nro_puertas
        if max_velocidad:
            self.max_velocidad = max_velocidad
        if cilindraje:
            self.cilindraje = cilindraje
        if nro_pasajeros:
            self.nro_pasajeros = nro_pasajeros
        if largo:
            self.largo = largo
        if modelo:
            self.modelo = modelo
        if ano:
            self.ano = ano
        if peso:
            self.peso = peso
        if capacidad_tanque:
            self.capacidad_tanque = capacidad_tanque

    @property
    def marca(self):
        return self._marca.upper()

    @marca.setter
    def marca(self, value):
        if not value or len(value) < 3:
            raise ValueError("Revise la marca que no sea nula y que tenga más de 3 caracteres")
        self._marca = value

    @property
    def color(self):
        return self._color

    @color.setter
    def color(self, value):
        self._color = value

    @property
    def nro_puertas(self):
        return self._nro_puertas

    @nro_puertas.setter
    def nro_puertas(self, value):
        if value < 1 or value > 6:
            raise ValueError("Revise el número de puertas, debe estar entre 1 y 6")
        self._nro_puertas = value

    @property
    def max_velocidad(self):
        return self._max_velocidad

    @max_velocidad.setter
    def max_velocidad(self, value):
        if value < 120 or value > 532:
            raise ValueError("Revise la velocidad máxima, entre 120 y 532")
        self._max_velocidad = value

    @property
    def cilindraje(self):
        return self._cilindraje

    @cilindraje.setter
    def cilindraje(self, value):
        if value < 800 or value > 7000:
            raise ValueError("Revise el cilindraje, entre 800 y 7000cc")
        self._cilindraje = value

    @property
    def nro_pasajeros(self):
        return self._nro_pasajeros

    @nro_pasajeros.setter
    def nro_pasajeros(self, value):
        if value < 1 or value > 7:
            raise ValueError("Revise el número de pasajeros, entre 1 y 7")
        self._nro_pasajeros = value

    @property
    def largo(self):
        return self._largo

    @largo.setter
    def largo(self, value):
        if value < 1.5 or value > 5:
            raise ValueError("Revise el largo, entre 1.5 y 5 metros")
        self._largo = value

    @property
    def modelo(self):
        return self._modelo

    @modelo.setter
    def modelo(self, value):
        if not value or len(value) < 1:
            raise ValueError("Revise el modelo que no sea nulo y que tenga mínimo 1 caracter")
        self._modelo = value

    @property
    def ano(self):
        return self._ano

    @ano.setter
    def ano(self, value):
        current_year = 2024
        if value < 2000 or value > current_year + 1:
            raise ValueError(f"Revise el año, no debe ser menor a 2000 ni mayor a {current_year + 1}")
        self._ano = value

    @property
    def peso(self):
        return self._peso

    @peso.setter
    def peso(self, value):
        if value < 690 or value > 5000:
            raise ValueError("Revise el peso, no puede ser mayor que 5000kg ni menor que 690kg")
        self._peso = value

    @property
    def capacidad_tanque(self):
        return self._capacidad_tanque

    @capacidad_tanque.setter
    def capacidad_tanque(self, value):
        if value < 5 or value > 20:
            raise ValueError("Revise la capacidad del tanque, no puede ser mayor que 20 galones ni menor que 5 galones")
        self._capacidad_tanque = value

    @property
    def nivel_tanque(self):
        return self._nivel_tanque

    @property
    def encendido(self):
        return self._encendido

    def encender(self):
        if not self._encendido and self._nivel_tanque > 0:
            self._encendido = True
        else:
            raise RuntimeError("No se puede encender porque no tiene combustible")

    def apagar(self):
        if self._encendido:
            self._encendido = False
        else:
            raise RuntimeError("El auto está apagado")

    def cargar_combustible(self):
        if not self._encendido and self._nivel_tanque < self._capacidad_tanque:
            self._nivel_tanque = self._capacidad_tanque
        else:
            raise RuntimeError("Debe apagar el auto o el tanque está lleno")

    def cargar_combustible_con_dinero(self, cant_dinero, precio_galon):
        if not self._encendido and cant_dinero > 0 and precio_galon > 0:
            cantidad_galones = cant_dinero / precio_galon
            if (cantidad_galones + self._nivel_tanque) > self._capacidad_tanque:
                raise RuntimeError("La cantidad de galones que está comprando excede la capacidad del tanque")
            self._nivel_tanque += cantidad_galones
            return True
        raise RuntimeError("Revise la cantidad del dinero y que el auto esté apagado")

    def cargar_combustible_con_galones(self, cantidad_galones):
        if cantidad_galones > 0 and not self._encendido and (cantidad_galones + self._nivel_tanque) <= self._capacidad_tanque:
            self._nivel_tanque += cantidad_galones
            return True
        raise RuntimeError("Revise la cantidad de galones a cargar si excede la capacidad del tanque o el auto debe estar apagado")
