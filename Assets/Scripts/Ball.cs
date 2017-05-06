using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    private Vector3 ballPaddleDiff;
    private bool hasStarted;

    // Use this for initialization
    private void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        ballPaddleDiff = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!hasStarted)
        {
            transform.position = paddle.transform.position + ballPaddleDiff;

            if (Input.GetMouseButtonDown(0))
            {
                print("click");
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 12f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 random = new Vector2(Random.Range(0f,0.2f),Random.Range(0f,0.2f));
        if (hasStarted)
        {
            AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
            GetComponent<Rigidbody2D>().velocity += random;
        }
    }
}