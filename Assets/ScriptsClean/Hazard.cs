using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    [SerializeField] private string targetTag = "Player";
    [SerializeField] private float delay = 0.15f; // pequeño retraso para ver el contacto

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(targetTag)) return;
        Debug.Log("Hazard: tocó el jugador. Reiniciando...");

        // (Opcional) desactivar control del player aquí si lo necesitas
        Invoke(nameof(ReloadCurrentScene), delay);
    }

    private void ReloadCurrentScene()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
}
