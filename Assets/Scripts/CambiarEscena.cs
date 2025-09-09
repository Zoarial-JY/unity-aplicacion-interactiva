using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CargarPorNombre(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // o LoadSceneAsync
    }

    public void CargarSiguiente()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i + 1);
    }

    public void CargarAnterior()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(Mathf.Max(0, i - 1));
    }
}
