using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay;
    private Ball ball;

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (autoPlay)
        {
            MoveWithBall();
        }
        else
        {
            MoveWithMouse();
        }
    }

    public void MoveWithBall()
    {
        Vector3 paddlePosn = new Vector3(0.5f, transform.position.y, 0f);
        Vector3 ballPosn = ball.transform.position;
        paddlePosn.x = Mathf.Clamp(ballPosn.x, 0.5f, 15.5f);
        transform.position = paddlePosn;
    }

    public void MoveWithMouse()
    {
        Vector3 paddlePosn = new Vector3(0.5f, transform.position.y, 0f);
        float mousePosn = Input.mousePosition.x / Screen.width * 16;
        paddlePosn.x = Mathf.Clamp(mousePosn, 0.5f, 15.5f);
        transform.position = paddlePosn;
    }
}