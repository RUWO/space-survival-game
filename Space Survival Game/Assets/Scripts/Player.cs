using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Player : MonoBehaviour {

    // Update is called once per frame
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float defaultMoveSpeed = 3.0f;
    public float MoveSpeed = 3.0f;
    public float RunSpeed = 8.0f;

    public GameObject prefab;
    public Camera camera;
    RaycastHit hit;

    public Material Looking;
    public Material NotLooking;

    public GameObject parent;

    private static bool paused = false;
    public class StringEvent : UnityEvent<string> { }

    private static GUI gui;

    public bool flying = true;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        GetComponent<Renderer>().enabled = false;
    }

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {

        GameObject cam = GameObject.Find("Main Camera");

        transform.forward = new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused) ReturnToGame();
            else Pause();
        }

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, -200, 0));
        }

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), /**speedV * Input.GetAxis("Mouse Y")*/0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (Input.GetKeyDown("space"))
            moveDirection.y = jumpSpeed;

        GetComponent<Rigidbody>().AddForce((moveDirection * 50) * Time.deltaTime);

        if (!paused) {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
        }

        cam.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        //if (Input.GetKeyDown("escape"))
        if (!paused) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;

        Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        BoxCollider box = hit.collider as BoxCollider;
        //MeshCollider box = hit.collider as MeshCollider;

        if (Physics.Raycast(ray, out hit))
        {
            print("I'm looking at " + hit.transform.name);
            //box.GetComponent<Renderer>().material = Looking;

            if (Input.GetMouseButtonDown(1))
            {
                Destroy(box.gameObject);
                print("Removed block");
            }

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 V = new Vector3(Mathf.Ceil(hit.point.x)+2.0f, Mathf.Ceil(hit.point.y)+2.0f, Mathf.Ceil(hit.point.z)+2.0f);
                Instantiate(box.gameObject, V, box.transform.rotation);
                print("Block Added");
            }

            else
                print("I'm looking at nothing!");

        }

    }

    /**
     * if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    */

    public static void Pause()
    {
        Time.timeScale = 0;
        paused = true;
        //GUI.menu.SetActive(true);
    }

    public static void ReturnToGame()
    {
        Time.timeScale = 1;
        paused = false;
        //GUI.menu.SetActive(false);
    }
 
    void OnGUI()
    {
        if (GUILayout.Button("Back To Game"))
            Debug.Log("Hello!");
    }

}
