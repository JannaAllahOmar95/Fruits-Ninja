using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health = 3;
    [SerializeField] private TextMeshProUGUI HealthText;
    [SerializeField] private GameObject LooserScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bomb"))
        {
            health--;
            if (health<=0)
            {
                LooserScreen.SetActive(true);
                Time.timeScale = 0;
            }
            HealthText.text = "Health: " + health;
        }
    }

}
