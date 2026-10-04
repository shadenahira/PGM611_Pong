using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidad = 6f;

    // Sonidos
    public AudioClip sonidoRebote;
    public AudioClip sonidoPunto;

    private Rigidbody2D rb;
    private Marcador marcador;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        marcador = FindFirstObjectByType<Marcador>();

        LanzarPelota();
    }

    void LanzarPelota()
    {
        // Elegir dirección horizontal
        float direccionX = Random.value < 0.5f ? -1f : 1f;

        // Elegir dirección vertical
        float direccionY = Random.value < 0.5f ? -0.6f : 0.6f;

        Vector2 direccion =
            new Vector2(direccionX, direccionY).normalized;

        rb.linearVelocity = direccion * velocidad;
    }

    void Update()
    {
        // Sale por la derecha:
        // punto para Jugador 1
        if (transform.position.x >= 9f)
        {
            if (audioSource != null && sonidoPunto != null)
            {
                audioSource.PlayOneShot(sonidoPunto);
            }

            if (marcador != null)
            {
                marcador.PuntoJugador1();
            }

            ReiniciarPelota();
        }

        // Sale por la izquierda:
        // punto para Jugador 2
        if (transform.position.x <= -9f)
        {
            if (audioSource != null && sonidoPunto != null)
            {
                audioSource.PlayOneShot(sonidoPunto);
            }

            if (marcador != null)
            {
                marcador.PuntoJugador2();
            }

            ReiniciarPelota();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ==========================
        // REBOTE EN PAREDES
        // ==========================

        if (collision.gameObject.name == "ParedSuperior" ||
            collision.gameObject.name == "ParedInferior")
        {
            // Sonido de rebote
            ReproducirRebote();

            float nuevaY = -rb.linearVelocity.y;

            // Evitar que quede moviéndose casi horizontal
            if (Mathf.Abs(nuevaY) < 2f)
            {
                if (collision.gameObject.name == "ParedSuperior")
                {
                    nuevaY = -3f;
                }
                else
                {
                    nuevaY = 3f;
                }
            }

            Vector2 nuevaDireccion = new Vector2(
                rb.linearVelocity.x,
                nuevaY
            ).normalized;

            rb.linearVelocity =
                nuevaDireccion * velocidad;
        }

        // ==========================
        // REBOTE EN JUGADOR 1
        // ==========================

        else if (collision.gameObject.name == "Jugador1")
        {
            // Sonido de rebote
            ReproducirRebote();

            float diferenciaY =
                transform.position.y -
                collision.transform.position.y;

            diferenciaY = Mathf.Clamp(
                diferenciaY,
                -0.8f,
                0.8f
            );

            // Siempre sale hacia la derecha
            Vector2 direccion = new Vector2(
                1f,
                diferenciaY
            ).normalized;

            rb.linearVelocity =
                direccion * velocidad;
        }

        // ==========================
        // REBOTE EN JUGADOR 2
        // ==========================

        else if (collision.gameObject.name == "Jugador2")
        {
            // Sonido de rebote
            ReproducirRebote();

            float diferenciaY =
                transform.position.y -
                collision.transform.position.y;

            diferenciaY = Mathf.Clamp(
                diferenciaY,
                -0.8f,
                0.8f
            );

            // Siempre sale hacia la izquierda
            Vector2 direccion = new Vector2(
                -1f,
                diferenciaY
            ).normalized;

            rb.linearVelocity =
                direccion * velocidad;
        }
    }

    void ReproducirRebote()
    {
        if (audioSource != null && sonidoRebote != null)
        {
            audioSource.PlayOneShot(sonidoRebote);
        }
    }

    void ReiniciarPelota()
    {
        // Regresar al centro
        transform.position = Vector2.zero;

        // Detener movimiento anterior
        rb.linearVelocity = Vector2.zero;

        // Lanzar nuevamente
        LanzarPelota();
    }
}