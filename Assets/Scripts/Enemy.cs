using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public float minSpeed;
    public float maxSpeed;

    private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed=Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed*Time.deltaTime*Vector3.down);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

        if (other.tag == "Player")
        {
            Player p = other.GetComponent<Player>();
            p.takeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
