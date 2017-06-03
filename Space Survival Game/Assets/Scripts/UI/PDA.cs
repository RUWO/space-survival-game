using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDA : MonoBehaviour {

    public Canvas parent;

	// Use this for initialization
	void Start () {
		
	}

    public void closePDA()
    {
        parent.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
