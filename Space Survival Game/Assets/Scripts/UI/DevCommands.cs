using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevCommands : MonoBehaviour {

    public InputField ip;
    public GameObject player;

    public bool isShowing = false;

	// Use this for initialization
	void Start () {
		
	}

    public void checkCommand()
    {
        string command = ip.text.Split(null)[0];

        if(command.Length>0)
        {
            string[] args = command.Split(null);
            switch(command)
            {
                case "gravity":
                    player.GetComponent<Rigidbody>().useGravity = !player.GetComponent<Rigidbody>().useGravity;
                    break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("enter"))
        {
            checkCommand();
        }
            
    }
}
