using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer _instance;

    private void Awake()
    {
        Debug.Log("Awake music player " + GetInstanceID());
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            print("Destroying gameObject MusicPlayer");
        }
    }

    // Use this for initialization
    private void Start()
    {
        Debug.Log("Starting music player " + GetInstanceID());
    }
}