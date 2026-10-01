using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidad = 6f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Elegir aleatoriamente si comienza hacia la izquierda o derecha
        float direccionX = Random.value < 0.5f ? -1f : 1f;

        // Elegir una pequeña dirección vertical
        float direccionY = Random.Range(-0.8f, 0.8f);

        Vector2 direccion = new Vector2(direccionX, direccionY).normalized;

        rb.linearVelocity = direccion * velocidad;
    }
}