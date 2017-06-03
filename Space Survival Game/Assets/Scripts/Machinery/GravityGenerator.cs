using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float pullRadius = 2;
    public float pullForce = 1;

    public void FixedUpdate()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, pullRadius)) {
            // calculate direction from target to me
            Vector3 forceDirection = transform.position - collider.transform.position;

            // apply force on target towards me
            try
            {
                collider.GetComponent<Rigidbody>().AddForce(forceDirection * pullForce * Time.fixedDeltaTime);
            }catch(MissingComponentException) { }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
