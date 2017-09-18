/*using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject CurrentFloor;
	//private GameObject prevFloor;
	public GameObject[] NewFloor;
	// Use this for initialization
	void Start () {
		for(int i=1;i<=3;i++)
			spawnFloor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void spawnFloor()
	{
		int rnd = Random.Range (0, 3);
		//prevFloor = (GameObject)CurrentFloor;
		CurrentFloor = (GameObject)Instantiate (NewFloor[rnd], CurrentFloor.transform.GetChild (0).position, Quaternion.identity);
		//Destroy (prevFloor, 2.0f);
	}

}*/
