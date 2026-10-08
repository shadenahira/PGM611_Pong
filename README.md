# Créditos de recursos externos

Este proyecto utiliza diferentes recursos gráficos y sonoros externos con fines
académicos para mejorar la presentación visual y la experiencia del videojuego
Pong desarrollado en Unity.

A continuación, se reconocen los recursos utilizados, sus autores o plataformas
de procedencia y la forma en la que fueron implementados dentro del proyecto.

## Recursos gráficos

### Breakout Pixel Art

Pack de recursos gráficos pixel art utilizado para personalizar algunos
elementos visuales principales del juego.

**Recursos utilizados:**
- `ball_default`: sprite utilizado para la pelota durante la partida.
- `paddle`: sprite utilizado para las paletas de ambos jugadores.

**Nombre del paquete descargado:** `breakout_pixel_art`

Los recursos pertenecen a su respectivo creador y fueron utilizados con fines
académicos dentro del proyecto.

---

### Pong Pixel Art

Pack de recursos pixel art utilizado principalmente para mejorar visualmente
el menú principal del videojuego.

**Autor:** ElectDraw  
**Plataforma:** OpenGameArt  
**Licencia:** CC0 / Public Domain

**Recursos utilizados:**
- `bluepongbig.png`: paleta azul utilizada como elemento decorativo del menú.
- `redpongbig.png`: paleta roja utilizada como elemento decorativo del menú.
- `balls.png`: spritesheet que contiene diferentes diseños de pelotas.
- `balls_0`: sprite seleccionado de `balls.png` y utilizado como pelota
  decorativa en el menú principal.

Estos elementos fueron configurados dentro de Unity como sprites 2D y
utilizados para representar visualmente la temática de Pong desde la pantalla
principal.

---

### Modern City Backgrounds Pixel Art

Pack de fondos pixel art utilizado para mejorar la presentación del menú
principal.

**Recurso:** Modern City Backgrounds Pixel Art  
**Autor/Publicador:** Free Game Assets / CraftPix  
**Plataforma:** itch.io  
**Uso en el proyecto:** fondo pixel art de ciudad utilizado en la escena
`Menu` para reemplazar el fondo de color plano y darle una apariencia más
atractiva al videojuego.

Fuente:
https://free-game-assets.itch.io/free-city-backgrounds-pixel-art

---

## Recursos de audio

### Head in the Sand (Seamless Loop)

Música de estilo retro/arcade utilizada como música ambiental del menú
principal.

**Nombre:** Head in the Sand (seamless loop)  
**Autor:** congusbongus  
**Plataforma:** OpenGameArt  
**Licencia:** CC0  
**Archivo utilizado:** `headinthesand.ogg`  
**Uso en el proyecto:** música de fondo de la escena `Menu`.

El audio fue configurado mediante un componente `Audio Source` de Unity,
utilizando las opciones `Play On Awake` y `Loop` para que la música comience
automáticamente y se reproduzca continuamente mientras el jugador permanece
en el menú.

---

### Point Smooth Beep

**Nombre:** Point Smooth Beep  
**Autor:** RibhavAgrawal  
**Plataforma:** Pixabay  
**Uso en el proyecto:** efecto de sonido relacionado con la puntuación de los
jugadores.  
**Licencia:** Pixabay Content License.

Fuente:
https://pixabay.com/sound-effects/point-smooth-beep-230573/

---

### Winner Game Sound

**Nombre:** Winner Game Sound  
**Autor:** PuyoPuyoMegaFan1234  
**Plataforma:** Pixabay  
**Uso en el proyecto:** sonido reproducido al finalizar una partida y anunciar
al jugador ganador.  
**Licencia:** Pixabay Content License.

Fuente:
https://pixabay.com/sound-effects/film-special-effects-winner-game-sound-404167/

---

### Efecto de colisión y rebote

**Recurso:** efecto de sonido utilizado durante las colisiones y rebotes de la
pelota.  
**Plataforma:** Pixabay  
**Uso en el proyecto:** se reproduce cuando la pelota colisiona con elementos
del escenario o con las paletas.

El recurso pertenece a su respectivo creador y fue utilizado únicamente con
fines académicos.

---

## Implementación propia del menú

Además de los recursos externos mencionados, el menú principal fue diseñado e
implementado dentro de Unity como parte del desarrollo del proyecto.

Entre los elementos implementados se encuentran:

- Escena principal `Menu`.
- Título del videojuego `PONG`.
- Botón `JUGAR`, conectado mediante C# con la escena `Juego`.
- Botón `SALIR`, encargado de cerrar la aplicación.
- Fondo pixel art de ciudad.
- Paletas azul y roja decorativas.
- Pelota pixel art decorativa.
- Música de fondo reproducida mediante `Audio Source`.
- Organización de los elementos utilizando `Canvas` y componentes de interfaz
  de Unity.
- Script `MenuPrincipal.cs` para controlar la navegación desde el menú hacia
  el juego.

El botón `JUGAR` permite iniciar correctamente la partida cargando la escena
del juego, mientras que el botón `SALIR` permite finalizar la aplicación.

---

## Nota sobre el uso de recursos

Todos los recursos externos mencionados pertenecen a sus respectivos autores
o plataformas de distribución.

Su utilización dentro de este proyecto tiene fines académicos y educativos.
Se han respetado las condiciones de uso y licencias indicadas por las fuentes
originales.

Los recursos externos fueron integrados, configurados y adaptados dentro de
Unity para formar parte del videojuego Pong desarrollado por el equipo.