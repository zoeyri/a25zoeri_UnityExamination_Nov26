using UnityEngine;
using TMPro;

public class HealthTextSync : MonoBehaviour
{
    public Health targetHealth;       // Drag your Player here
    public TextMeshProUGUI textBox;   // Drag your Text (TMP) here

    void Update()
    {
        if (targetHealth != null && textBox != null)
        {
            textBox.text = targetHealth.currentHealth.ToString("0");
        }
    }
}