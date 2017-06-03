using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldGenerator : MonoBehaviour {

    public GameObject forcefield;
    public TextMesh text;
    public GameObject baseHolder;

    public bool powered;

	// Use this for initialization
	void Start () {
        setPowered(false);
    }

    public void setPowered(bool p)
    {
        powered = p;
        text.text = p == true ? "POWERED" : "UNPOWERED";
        text.color = p == true ? Color.green : Color.red;
        forcefield.GetComponent<Renderer>().enabled = p;
        forcefield.GetComponent<MeshCollider>().enabled = p;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
