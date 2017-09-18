using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, -7.5f, 0);

    void Update()
    {
        float xPos = transform.position.x;

        if (KinectManager.instance.IsAvailable)
        {
            xPos = KinectManager.instance.PaddlePosition;
        }
        else
        {
            xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        }
        
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -7.5f, 0f);

        transform.position = playerPos;
    }
}



