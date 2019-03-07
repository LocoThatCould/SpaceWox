/*
using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
    public int attackDamage = 10;               // The amount of health taken away per attack.


    Animator anim;                              // Reference to the animator component.
    Transform player;                          // Reference to the player GameObject.
    PlayerHealth playerHealth;                  // Reference to the player's health.
    EnemyScript enemyHealth;                    // Reference to this enemy's health.
    bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
    float timer;                                // Timer for counting up to the next attack.

    // Переменная для звука нанесения урона
    public AudioClip damageSound;

    void Start()
    {
        // Setting up the references.
        player = GameObject.Find("playerShip").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyScript>();
        anim = GetComponent<Animator>();

        Debug.Log("Atatck");
    }



    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
        }
        Debug.Log("Atatck");
    }


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is no longer in range.
            playerInRange = false;
        }
        Debug.Log("Atatck");
    }


    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.Enemyhealth > 0)
        {
            // ... attack.
            Attack();
            // Воспроизвести звук выстрела лазером
                //GetComponent<AudioSource>().PlayOneShot(shootSound);
        }

        // If the player has zero or less health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the player is dead.
            anim.SetTrigger("PlayerDead");
        }
        Debug.Log("Atatck");
    }


    void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if (playerHealth.currentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage(attackDamage);
        }
        Debug.Log("Atatck");
    }
}
*/