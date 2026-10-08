using UnityEngine;
using UnityEngine.SceneManagement;

public class FinPartidaUI : MonoBehaviour
{
    public void ReiniciarPartida()
    {
        // Restaurar el tiempo antes de reiniciar
        Time.timeScale = 1f;

        // Recargar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VolverAlMenu()
    {
        // Restaurar el tiempo porque el juego termina pausado
        Time.timeScale = 1f;

        // Cargar la escena del menú principal
        SceneManager.LoadScene("Menu");
    }

    public void SalirDelJuego()
    {
        // Restaurar el tiempo
        Time.timeScale = 1f;

        // Cerrar el ejecutable
        Application.Quit();

#if UNITY_EDITOR
        // Permite probar SALIR dentro del editor
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}