using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public TMP_FontAsset fuenteA;
    public TMP_FontAsset fuenteB;
    public float paso = 2f;

    public void Aumentar()
    {
        if (texto != null && texto.enableAutoSizing)
        {
            texto.fontSizeMax += paso;
            texto.fontSizeMin += paso;
        }
        else if (texto != null)
        {
            texto.fontSize += paso;
        }
    }       

     public void Disminuir()
    {
        if (texto != null && texto.enableAutoSizing)
        {
            texto.fontSizeMax = Mathf.Max(10f, texto.fontSizeMax - paso);
            texto.fontSizeMin = Mathf.Max(5f, texto.fontSizeMin - paso);
        }
        else if (texto != null)
        {
            texto.fontSize = Mathf.Max(1f, texto.fontSize - paso);
        }
    }

    public void CambiarAFuenteA(){
        if (texto != null && fuenteA != null) texto.font = fuenteA;
    }

    public void CambiarAFuenteB(){
        if (texto != null && fuenteB != null) texto.font = fuenteB;
    }
}
