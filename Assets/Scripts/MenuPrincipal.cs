using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string nombreEscenaJuego = "Juego";

    public void Jugar()
    {
        SceneManager.LoadScene(nombreEscenaJuego);
    }

    public void Salir()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}