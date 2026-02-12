using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    public GameObject deathCanvas;
    public TMP_Text healthText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        onRestartClick();
    }

    public void deathCanvasSwitch(bool value)
    {
        deathCanvas.SetActive(value);
    }

    public void onRestartClick()
    {
        p.reset();
        spawner.reset();
        updateHealthText(p.maxHealth);
        deathCanvasSwitch(false);
    }

    public void updateHealthText(int value)
    {
        healthText.text = "x"+value.ToString();
    }
    
    public void onMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
