using UnityEngine;

public class MusicManager : MonoBehaviour
{
   private static MusicManager _instance=null;

   void Awake()
   {
      if (_instance == null)
      {
         _instance = this;
      }
      else
      {
         Destroy(gameObject);
      }
      DontDestroyOnLoad(gameObject);
   }
   
   public static MusicManager instance()
   {
        return _instance;
   }
}
