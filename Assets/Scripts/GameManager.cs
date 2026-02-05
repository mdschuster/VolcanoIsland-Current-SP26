using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance=null;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public static GameManager instance()
    {
        return _instance;
    }

    private Player p;
    public Spawner spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        p.reset();
        spawner.reset();
    }
    
}
