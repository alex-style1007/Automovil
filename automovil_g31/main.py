from clases.Automovil import Automovil
from clases.persona import Persona

def main():
    # Crear instancias de Automovil
    auto1 = Automovil(marca="Toyota", modelo="Corolla", ano=2020, color=Automovil.Colores.AZUL, nro_puertas=4, max_velocidad=180, cilindraje=2000, nro_pasajeros=5, largo=4.5, peso=1500, capacidad_tanque=15)
    auto2 = Automovil(marca="Honda", modelo="Civic", ano=2021, color=Automovil.Colores.ROJO, nro_puertas=4, max_velocidad=200, cilindraje=2200, nro_pasajeros=5, largo=4.6, peso=1400, capacidad_tanque=16)
    
    # Crear instancia de Persona
    persona = Persona(nombre="Juan Perez", id="123456")

    # Agregar automóviles a la persona
    persona.agregar_automovil(auto1)
    persona.agregar_automovil(auto2)

    # Mostrar automóviles de la persona
    persona.mostrar_automoviles()

    # Eliminar un automóvil y mostrar nuevamente
    persona.eliminar_automovil(auto1)
    persona.mostrar_automoviles()

    # Eliminar el automóvil restante por índice y mostrar nuevamente
    persona.eliminar_automovil_por_indice(0)
    persona.mostrar_automoviles()

if __name__ == "__main__":
    main()