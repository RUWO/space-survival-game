using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public GameObject block;
    public Camera camera;

	// Use this for initialization
	void Start () {
        
    }

    void OnMouseDown()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider box = hit.collider as BoxCollider;
                Vector3 localPoint = hit.transform.InverseTransformPoint(hit.point);
                Vector3 localDir = localPoint.normalized;

                /**float upDot = Vector3.Dot(localDir, Vector3.up);
                float fwdDot = Vector3.Dot(localDir, Vector3.forward);
                float rightDot = Vector3.Dot(localDir, Vector3.right);

                Vector3 pos = block.transform.position;
                if (fwdDot > 0)
                {
                    pos.Set(pos.x, pos.y, pos.z + 1f);
                    Instantiate(block, pos, block.transform.rotation, block.transform);
                }else if (fwdDot < 0)
                {
                    pos.Set(pos.x, pos.y, pos.z - 1f);
                    Instantiate(block, pos, block.transform.rotation, block.transform);
                }else if(upDot > 0)
                {
                    pos.Set(pos.x, pos.y + 1f, pos.z);
                    Instantiate(block, pos, block.transform.rotation, block.transform);
                }*/
                return;
            }
        }
    }
}
