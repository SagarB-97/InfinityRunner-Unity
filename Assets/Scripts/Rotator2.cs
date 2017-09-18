using UnityEngine;
using System.Collections;

public class Rotator2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(2,3,1));
    }
}
