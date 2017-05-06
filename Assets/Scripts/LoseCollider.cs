using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelManager;

    public void OnCollisionEnter2D(Collision2D other)
    {
        print("collision");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("trigger");
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Win_Screen");
    }
}