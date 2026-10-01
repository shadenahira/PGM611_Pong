using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidad = 6f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? -0.6f : 0.6f;

        rb.linearVelocity = new Vector2(x, y).normalized * velocidad;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pared superior
        if (collision.gameObject.name == "ParedSuperior")
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                -3.5f
            ).normalized * velocidad;
        }

        // Pared inferior
        else if (collision.gameObject.name == "ParedInferior")
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                3.5f
            ).normalized * velocidad;
        }

        // Paleta izquierda
        else if (collision.gameObject.name == "Jugador1")
        {
            float y = transform.position.y -
                      collision.transform.position.y;

            rb.linearVelocity =
                new Vector2(1f, y * 0.5f).normalized * velocidad;
        }

        // Paleta derecha
        else if (collision.gameObject.name == "Jugador2")
        {
            float y = transform.position.y -
                      collision.transform.position.y;

            rb.linearVelocity =
                new Vector2(-1f, y * 0.5f).normalized * velocidad;
        }
    }
}