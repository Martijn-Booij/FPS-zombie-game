using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float health = 100;              // De gezondheid van de speler
    public Text healthText;                 // Tekstveld voor het weergeven van de gezondheid

    public GameManager gameManager;         // Verwijzing naar de GameManager-component

    public void Hit(float damage) 
    {
        health -= damage;                   // Verminder de gezondheid met de ontvangen schade
        healthText.text = "Health " + health.ToString();    // Werk de gezondheidstekst bij

        if(health <= 0) {
            gameManager.EndGame();          // Roep de EndGame-methode aan in de GameManager om het einde van het spel te activeren
        }
    }
}
