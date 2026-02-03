using UnityEngine;
using UnityEngine.UI;

public class PlanetClick : MonoBehaviour
{
    public Text planetText;

    void OnMouseDown()
    {
        if (planetText != null)
        {
            planetText.text = gameObject.name;
        }
    }
}


