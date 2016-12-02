using UnityEngine;
using System.Collections;

public class Interactiveobjectbehaviour : MonoBehaviour {

    public GameObject interactiveObject;
    // Use this for initialization
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
     }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Activated");
	}


}
