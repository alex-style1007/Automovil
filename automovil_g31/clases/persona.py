class Persona:
    def __init__(self, nombre, id, l_automoviles=None):
        self.nombre = nombre
        self.id = id
        self.l_automoviles = l_automoviles if l_automoviles is not None else []

    @property
    def nombre(self):
        return self._nombre.upper()

    @nombre.setter
    def nombre(self, value):
        if not value or len(value.strip()) < 6:
            raise ValueError("Revise que el nombre tenga más de 6 caracteres y no sea nulo o vacío.")
        self._nombre = value

    @property
    def id(self):
        return self._id

    @id.setter
    def id(self, value):
        if not value or len(value.strip()) < 6:
            raise ValueError("Revise que el ID tenga más de 6 caracteres y no sea nulo o vacío. No se pudo crear el objeto.")
        self._id = value

    @property
    def l_automoviles(self):
        return self._l_automoviles

    @l_automoviles.setter
    def l_automoviles(self, value):
        if not isinstance(value, list):
            raise ValueError("l_automoviles debe ser una lista.")
        self._l_automoviles = value

    def agregar_automovil(self, automovil):
        if not isinstance(automovil, Automovil):
            raise ValueError("El objeto agregado debe ser una instancia de Automovil.")
        self._l_automoviles.append(automovil)

    def eliminar_automovil(self, automovil):
        try:
            self._l_automoviles.remove(automovil)
        except ValueError:
            raise ValueError("El automóvil no se encuentra en la lista.")

    def eliminar_automovil_por_indice(self, index):
        if index < 0 or index >= len(self._l_automoviles):
            raise IndexError("Índice fuera de rango.")
        self._l_automoviles.pop(index)

    def mostrar_automoviles(self):
        if not self._l_automoviles:
            print("La persona no tiene automóviles.")
            return

        print(f"Automóviles de {self.nombre}:")
        for auto in self._l_automoviles:
            print(f"- Marca: {auto.marca}, Modelo: {auto.modelo}, Año: {auto.ano}")
