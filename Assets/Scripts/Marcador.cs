using UnityEngine;
using TMPro;

public class Marcador : MonoBehaviour
{
    public TMP_Text textoJugador1;
    public TMP_Text textoJugador2;
    public TMP_Text textoGanador;

    // Panel que aparece cuando termina la partida
    public GameObject panelFinPartida;


    // Sonido de victoria
    public AudioClip sonidoGanador;

    private int puntosJugador1 = 0;
    private int puntosJugador2 = 0;

    public int puntosParaGanar = 5;

    private bool juegoTerminado = false;
    private AudioSource audioSource;

    void Start()
    {
        // Obtener el AudioSource del Canvas
        audioSource = GetComponent<AudioSource>();

        // Ocultar mensaje al comenzar
        textoGanador.gameObject.SetActive(false);

        // Ocultar el panel de final de partida
        if (panelFinPartida != null)
        {
            panelFinPartida.SetActive(false);
        }

        // Asegurarnos de que el tiempo esté funcionando
        Time.timeScale = 1f;
    }

    public void PuntoJugador1()
    {
        if (juegoTerminado)
            return;

        puntosJugador1++;
        textoJugador1.text = puntosJugador1.ToString();

        if (puntosJugador1 >= puntosParaGanar)
        {
            FinalizarJuego("¡JUGADOR 1 GANA!");
        }
    }

    public void PuntoJugador2()
    {
        if (juegoTerminado)
            return;

        puntosJugador2++;
        textoJugador2.text = puntosJugador2.ToString();

        if (puntosJugador2 >= puntosParaGanar)
        {
            FinalizarJuego("¡JUGADOR 2 GANA!");
        }
    }

    void FinalizarJuego(string mensaje)
    {
        juegoTerminado = true;

        // Mostrar el panel de final de partida
        if (panelFinPartida != null)
        {
            panelFinPartida.SetActive(true);
        }

        // Mostrar ganador
        textoGanador.text = mensaje;
        textoGanador.gameObject.SetActive(true);

        // Reproducir sonido de victoria
        if (audioSource != null && sonidoGanador != null)
        {
            audioSource.PlayOneShot(sonidoGanador);
        }

        // Pausar el juego
        Time.timeScale = 0f;
    }
}