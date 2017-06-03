using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Face : MonoBehaviour {

    public GameObject block;
    public Camera camera;
    public FACE face;

    public enum FACE
    {
        FRONT,
        BACK,
        LEFT,
        RIGHT,
        TOP,
        BOTTOM
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {  //if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider box = hit.collider as BoxCollider;
                Vector3 localPoint = hit.transform.InverseTransformPoint(hit.point);
                Vector3 localDir = localPoint.normalized;

                float upDot = Vector3.Dot(localDir, Vector3.up);
                float fwdDot = Vector3.Dot(localDir, Vector3.forward);
                float rightDot = Vector3.Dot(localDir, Vector3.right);

                /**Vector3 pos = box.transform.position;
                //pos.Set(pos.x, pos.y + 1f, pos.z);
                switch(face)
                {
                    case FACE.FRONT:
                        pos.Set(pos.x, pos.y, pos.z - 1f);
                        break;
                    case FACE.BACK:
                        pos.Set(pos.x, pos.y, pos.z + 1f);
                        break;
                    case FACE.BOTTOM:
                        pos.Set(pos.x, pos.y - 1f, pos.z);
                        break;
                    case FACE.TOP:
                        pos.Set(pos.x, pos.y + 1f, pos.z);
                        break;
                }
                Instantiate(block.gameObject, pos, block.transform.rotation);*/
            }
        }/**else if(Input.GetButtonDown("Fire3"))
        {
            Destroy(this.gameObject);
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        /**Vector3 pos = other.gameObject.transform.position;
        pos.Set(pos.x, pos.y + 1f, pos.z);
        Instantiate(block, pos, block.transform.rotation);*/
    }
}
