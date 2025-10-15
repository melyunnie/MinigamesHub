using UnityEngine;

public class DefaultStats : MonoBehaviour
{
    public static DefaultStats Instance;
    public Stats savedStats = new Stats();
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
 
}
