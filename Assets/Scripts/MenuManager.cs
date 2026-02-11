using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void onPlayClick()
    {
        //switch to MainGame Scene
        SceneManager.LoadScene("MainGame");
    }
}
