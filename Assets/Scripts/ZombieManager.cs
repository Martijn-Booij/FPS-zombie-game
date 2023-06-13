using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieManager : MonoBehaviour
{
    public GameObject player;                  // Verwijzing naar het GameObject van de speler
    public Animator enemyAnimator;             // Animator-component voor de vijand
    public float damage = 20f;                  // Schade die de vijand kan toebrengen
    public float zombiehealth = 100f;           // Gezondheid van de vijand
    public GameManager gameManager;            // Verwijzing naar de GameManager-component

    private bool isDead = false;                // Geeft aan of de vijand dood is

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   // Zoek het GameObject van de speler met de tag "Player"
    }

    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();    // Haal de NavMeshAgent-component op

        if (agent.isActiveAndEnabled && agent.isOnNavMesh)
        {
            agent.SetDestination(player.transform.position);    // Stel de bestemming van de zombie in op de positie van de speler

            if (agent.velocity.magnitude > 1)
            {
                enemyAnimator.SetBool("isRunning", true);     // Activeer de "isRunning" parameter in de animator als de zombie aan het rennen is
            }
            else
            {
                enemyAnimator.SetBool("isRunning", false);    // Deactiveer de "isRunning" parameter in de animator als de zombie niet rent
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(isDead)
        {
            return;                                 // Als de vijand dood is, stop dan met de methode
        }

        if (collision.gameObject.tag == "Bullet")
        {
            zombiehealth -= 50;                    // Verminder de gezondheid van de vijand bij een botsing met een kogel
        }

        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerManager>().Hit(damage);    // Roep de Hit-methode van de PlayerManager aan om schade toe te passen op de speler
        }

        if (zombiehealth <= 0)
        {
            isDead = true;                                     // Markeer de vijand als dood
            enemyAnimator.SetBool("isDead", true);              // Activeer de "isDead" parameter in de animator om de doodanimatie af te spelen
            GetComponent<NavMeshAgent>().enabled = false;       // Schakel de NavMeshAgent-component uit zodat de vijand stopt met bewegen
            gameManager.zombiesAlive--;                         // Verminder het aantal levende zombies in de GameManager
            Destroy(gameObject, 10);                            // Vernietig de vijand na 10 seconden
            gameManager.zombiesKilled++;                         // Verhoog het aantal gedode zombies in de GameManager
        }
    }
}
