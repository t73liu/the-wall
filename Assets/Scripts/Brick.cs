using UnityEngine;

public class Brick : MonoBehaviour
{
    private int timesHit;
    public static int breakableBlockCount;
    private LevelManager levelManager;
    public Sprite[] brokenBricks;
    private bool isBreakable;

    public AudioClip crack;

    // Use this for initialization
    private void Start()
    {
        isBreakable = tag == "Breakable";
        levelManager = FindObjectOfType<LevelManager>();
        if (isBreakable)
        {
            breakableBlockCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        timesHit++;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (isBreakable)
        {
            BreakingBricks();
        }
    }

    private void BreakingBricks()
    {
        int maxHits = brokenBricks.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableBlockCount--;
            AudioSource.PlayClipAtPoint(crack, transform.position);
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            if (brokenBricks[timesHit - 1] != null)
            {
                GetComponent<SpriteRenderer>().sprite = brokenBricks[timesHit - 1];
            }
        }
    }
}