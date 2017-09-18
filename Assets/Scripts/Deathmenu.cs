using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Deathmenu : MonoBehaviour
{
    
    //public ScoreManager sc;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ToggleEndMenu(float score)
    {
        
        
        gameObject.SetActive(true);
        //const int temp = (int)score;
        //Destroy(gameObject);
        scoreText.text = ((int)PlayerControl.score).ToString();

        Instantiate(this);
        
        
    }

    public void Restart()
    {
        PlayerControl.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

