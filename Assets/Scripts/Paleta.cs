using UnityEngine;

public class Paleta : MonoBehaviour
{
    public float velocidad = 7f;
    public bool jugador1;

    void Update()
    {
        float movimiento = 0f;

        // JUGADOR 1: W y S
        if (jugador1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                movimiento = 1f;
            }

            if (Input.GetKey(KeyCode.S))
            {
                movimiento = -1f;
            }
        }
        // JUGADOR 2: Flecha arriba y flecha abajo
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                movimiento = 1f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                movimiento = -1f;
            }
        }

        // Mover la paleta
        transform.Translate(
            Vector3.up * movimiento * velocidad * Time.deltaTime
        );

        // Evitar que salga de la cancha
        float posicionY = Mathf.Clamp(
            transform.position.y,
            -3.4f,
            3.4f
        );

        transform.position = new Vector3(
            transform.position.x,
            posicionY,
            transform.position.z
        );
    }
}