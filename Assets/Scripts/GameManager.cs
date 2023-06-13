using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int zombiesAlive = 0;            // Het aantal zombies dat nog in leven is
    public int round = 0;                   // Het huidige rondenummer
    public GameObject[] zombieSpawns;       // Array van GameObjects die als spawnpunten voor zombies dienen
    public GameObject enemyPrefab;          // Prefab voor de zombie
    public Text roundText;                  // Tekstveld voor het weergeven van het huidige rondenummer
    public GameObject WinScreen;            // Het WinScreen-object
    public GameObject EndScreen;            // Het EndScreen-object
    public Text RoundsSurvived;             // Tekstveld voor het weergeven van het aantal overleefde rondes
    public Text ZombiesKilled;              // Tekstveld voor het weergeven van het aantal gedode zombies
    public ZombieManager zombieManager;      // Verwijzing naar de ZombieManager-component
    public int zombiesKilled;                // Het aantal gedode zombies

    void Update()
    {
        if (zombiesAlive <= 0)
        {
            round++;                         // Verhoog het rondenummer
            NextWave();                      // Start de volgende golf zombies
            roundText.text = "Round: " + round.ToString();

            if (round >= 10)
            {
                WinGame();                   // Als het rondenummer 10 of hoger is, win het spel
            }
        }
    }

    public void NextWave()
    {
        int zombiesToSpawn = round + 1;     // Bepaal het aantal zombies dat moet worden gespawned voor de volgende golf

        for (int i = 0; i < zombiesToSpawn; i++)
        {
            GameObject zombieSpawn = zombieSpawns[Random.Range(0, zombieSpawns.Length)];   // Kies willekeurig een spawnpunt
            GameObject enemySpawned = Instantiate(enemyPrefab, zombieSpawn.transform.position, Quaternion.identity);   // Spawn een zombie op het spawnpunt
            enemySpawned.GetComponent<ZombieManager>().gameManager = this;   // Koppel de GameManager aan de ZombieManager van de gespawnde zombie
            zombiesAlive++;   // Verhoog het aantal zombies dat nog in leven is
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);   // Laad de eerste scène opnieuw om het spel te herstarten
    }

    public void WinGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        WinScreen.SetActive(true);   // Activeer het WinScreen-object
        RoundsSurvived.text = "Rounds Survived: " + round.ToString();   // Toon het aantal overleefde rondes
        ZombiesKilled.text = "Zombies Killed: " + zombiesKilled.ToString();   // Toon het aantal gedode zombies
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        EndScreen.SetActive(true);   // Activeer het EndScreen-object
        RoundsSurvived.text = "Rounds Survived: " + round.ToString();   // Toon het aantal overleefde rondes
        ZombiesKilled.text = "Zombies Killed: " + zombiesKilled.ToString();   // Toon het aantal gedode zombies
    }
}
