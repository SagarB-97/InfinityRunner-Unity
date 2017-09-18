using UnityEngine;
using System.Collections;

public class DeathCollision : MonoBehaviour {

    public Deathmenu d;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ethan")){
           // Debug.Log("Dead");
            d.ToggleEndMenu(PlayerControl.score);
           // Debug.Log("ASDF");
        }
    }
}
