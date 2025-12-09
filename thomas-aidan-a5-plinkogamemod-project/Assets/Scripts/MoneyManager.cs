using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour

{
    public static MoneyManager Instance;

    public int money = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep money between scene reloads
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
