using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 MouseSense;
    public float WalkSpeed,JumpForce;
    public float Heigh;
    public GameObject camera;

    private Rigidbody player;
    private float CamRot,LastVel ;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        Cursor.lockState  = CursorLockMode.Locked;
        LastVel = -0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //move
        Vector3 prev = player.transform.position;
        player.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        Vector3 move = player.transform.position - prev;
        player.transform.position = prev;
        move *= WalkSpeed;
        move.y = player.velocity.y;
        player.velocity = move;

        //jump
        if ((Input.GetAxis("Jump") == 1) && (player.velocity.y < 0.1) && (player.velocity.y >= 0) && (LastVel < 0)) player.AddForce( Vector3.up  * JumpForce,ForceMode.VelocityChange);
        if (player.velocity.y != 0) LastVel = player.velocity.y;

    }

    private void Update()
    {
        //rotation
        player.transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * MouseSense.y);
        CamRot += Input.GetAxis("Mouse Y") * MouseSense.x; 
    }

    private void LateUpdate()
    {
        //la cam au bonne endroit
        camera.transform.position = player.transform.position;
        camera.transform.eulerAngles = Vector3.zero;
        camera.transform.Translate(0, Heigh, 0);
        camera.transform.eulerAngles = new Vector3( CamRot,player.transform.eulerAngles.y,0 );
        
    }
}
