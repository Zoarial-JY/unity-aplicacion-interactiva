using UnityEngine;

public class AbrirURL : MonoBehaviour
{
    public void Ir(string url)
    {
        Application.OpenURL(url);
    }
}
