using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    public GameObject[] meteors;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float pullForce = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Meteor")
        {

            Vector3 forceDirection = this.transform.position - other.transform.position;

            other.GetComponent<Rigidbody>().AddForce(-forceDirection * pullForce);

        }
    }

}
