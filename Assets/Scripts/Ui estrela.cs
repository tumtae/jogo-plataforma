using TMPro;
using UnityEngine;

public class Uiestrela : MonoBehaviour
{
    public TextMeshProUGUI starText;
    int stars = 0;

    public void AddStar()
    {
        stars++;
        starText.text = "Estrelas: " + stars;
    }
}