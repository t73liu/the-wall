using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Lose Screen");
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose_Screen");
    }
}