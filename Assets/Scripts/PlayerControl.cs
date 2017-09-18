using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

	public float speed=10.0f;
    public float lrspeed = 8.0f;
	public GameObject Camera;
	private Vector3 direction,camOffset;
    float elapsedTime, startTime;

    static public float score = 0.0f;
    public Text scoretext;
    private float scoreToNext = 10.0f;
    public Deathmenu d;
	private bool isDead;
    public float EthanSpeed = 1f;

    private Vector3 playerPos = new Vector3(-147.55f, 171.3f, 18.605f);

    // Use this for initialization
    void Start () {

		isDead = false;
        scoretext.text = score.ToString();

        direction = Vector3.zero;
		camOffset = Camera.transform.position - transform.position;
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
        elapsedTime = Time.time - startTime;
        if (elapsedTime > 10)
        {
            speed = speed+10.0f;
            startTime = Time.time;
        }

        float xPos = transform.position.x;

        if (KinectManager.instance.IsAvailable)
        {
            xPos = KinectManager.instance.PaddlePosition;
        }
        else
        {
            xPos = transform.position.x + (Input.GetAxis("Horizontal") * EthanSpeed);
        }

        playerPos = new Vector3(xPos-147.5f, 171.3f, 18.605f);

        transform.position = playerPos;
        /*if (Input.anyKey) {
			if (Input.GetKey ("left") && transform.position.x>-168.3f)
				direction = Vector3.left;
			else if (Input.GetKey ("right") && transform.position.x < -131.9f)
				direction = Vector3.right;
			if (transform.position.x < -168.3f || transform.position.x > 131.9f)
				direction = Vector3.zero;
		} 
		else {
			direction = Vector3.zero;
		}*/
		float amountTomove = speed * Time.deltaTime;
        float lramountTomove = lrspeed * Time.deltaTime;
		transform.Translate (direction * lramountTomove*2);
		//transform.Translate (Vector3.forward * (amountTomove/2));
		Camera.transform.position = new Vector3 (Camera.transform.position.x, Camera.transform.position.y, camOffset.z + transform.position.z);

		if (isDead) {d.ToggleEndMenu (score);return;}
        if (score >= scoreToNext)
            LevelUp();
        int cons = (int)scoreToNext / 10;
        score += (Time.deltaTime * cons);
        scoretext.text = ((int)score).ToString();


    }

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Asteroid"))
		{
			Debug.Log ("Dead");
			isDead = true;
		}
	}

    void LevelUp()
    {
        scoreToNext *= 2;
    }

}
