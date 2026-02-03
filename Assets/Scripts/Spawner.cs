using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public float timeBetweenSpawn;
    private float timer;

    public GameObject Enemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            //Figure out where to spawn
            Vector3 location = new Vector3(Random.Range(-5.5f, 5.5f), 6.0f, 0f);
            //instantiate the object
            Instantiate(Enemy, location, Quaternion.identity);
            
            //reset the timer
            timer = timeBetweenSpawn;
            
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
