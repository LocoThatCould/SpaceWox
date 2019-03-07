using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Сколько раз нужно попасть во врага, чтобы уничтожить его
    public int Enemyhealth = 2;

    public float elapsedTime = 0.0f;

    public int enemyDamage = 10; //Дамаг врага

    Transform player;                          //Корабль
    PlayerHealth playerHealth;                  //ХП
    
    bool playerInRange;                         // Зона атаки

    // Переменная для звука нанесения урона
    public AudioClip damageSound;

    // Анимация при уничтожении объекта
    public Transform explosion;

    // Переменная для звука во время попадания лазера
    public AudioClip hitSound;


    void Start()
    {
        // Setting up the references.
        player = GameObject.Find("playerShip").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    public void IncreaseEnemyHealth(int increase)
    {
        Enemyhealth += increase;
    }

    //Атака
    private void OnCollisionStay2D(Collision2D theCollision)
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 0.5f)
        {
            elapsedTime = 0.0f;
            //Проверяем коллизию с объектом типа «корабль»
            if (theCollision.gameObject.name.Contains("playerShip"))
            {

            PlayerScript player = theCollision.gameObject.GetComponent("playerShip") as PlayerScript;
            playerHealth.TakeDamage(enemyDamage);
            // Воспроизвести звук атаки
            GetComponent<AudioSource>().PlayOneShot(damageSound);

            }
        }
    }

    //Попадание лазера
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        //Проверяем коллизию с объектом типа «лазер»
        if (theCollision.gameObject.name.Contains("laser"))
        {
            LaserScript laser = theCollision.gameObject.GetComponent("LaserScript") as LaserScript;
            Enemyhealth -= laser.damage;
            Destroy(theCollision.gameObject);
            // Воспроизвести звук попадания выстрела
            GetComponent<AudioSource>().PlayOneShot(hitSound);
        }


        if (Enemyhealth <= 0)
        {
            // Срабатывает при уничтожении объекта
            if (explosion)
            {
                GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(exploder, 2.0f);
            }

            Destroy(this.gameObject);

            GameController controller = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
            controller.KilledEnemy();
            controller.IncreaseScore(10);
        }

    }


}
