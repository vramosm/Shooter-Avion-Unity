# Shooter-Avion-Unity

Se crearán dos escenas (FPS y Avion) en un proyecto llamado "TuNombre_Shooter".

Escena FPS:

Deberá haber un escenario que conste de un laberinto personalizado y un suelo, creado todo con elementos BÁSICOS. (Recuerda que se valorará la optimización).
Nota: el color del laberinto y del suelo no podrá ser ni rojo ni morado, ya que podría confundirse con los enemigos.
Tendrá que haber un control tipo FPS, pudiendo usar el de los assets de Unity.
En el laberinto deberá haber 2 enemigos patrullando, que serán cubos de color ROJO.
Habrá un enemigo especial, un cubo de color MORADO, que siempre estará siguiendo al jugador, aunque sea a poca velocidad.
Los enemigos dispararán al jugador cuando estén a cierta distancia.
Se deberá poder disparar como si fuera un shooter. ¡IMPORTANTE!: las balas deben dirigirse a la dirección donde estemos mirando, ¡incluyendo el eje vertical!
Escena Avion:

Deberá haber un escenario que conste de un suelo de color MARRÓN y 4 esferas de color VERDE que estarán por el aire.
Se usará el avión compartido:
Avion
La cámara podrá ser hijo del avión para que lo siga.
Con los botones WASD el avión girará.
No es necesario que el avión sufra la fuerza gravitatoria.
El avión deberá avanzar/moverse automáticamente en la dirección a la que 'esté mirando'.
El avión disparará.
Cuando el avión toque las esferas verdes, estas desaparecerán.
Se creará un script llamado "ContadorEsferas", que sumará una unidad cada vez que toquemos las esferas y lo mostrará por consola.
