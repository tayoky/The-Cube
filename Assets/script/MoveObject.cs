using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float MaxDistance,Force;
    public Transform Camera;
    public GameObject Object;
    private Rigidbody ObjectRg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //dplacement de l'objet
        if (Object != null)
        {
            Vector3 dif = Object.transform.position - Camera.transform.position;
            if (dif.magnitude > 0.1)
            {
                //ObjectRg.AddForce(-dif * Force , ForceMode.Impulse) ;
                ObjectRg.velocity = -dif * Force;
            }

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            if (Object == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(this.transform.position, Camera.transform.TransformDirection(Vector3.forward), out hit, MaxDistance))
                {
                    if (hit.rigidbody != null)
                    {
                        ObjectRg = hit.rigidbody;
                        ObjectRg.useGravity = false;
                        Object = hit.transform.gameObject;

                        ObjectRg.freezeRotation = true;
                    }
                }
            }
            else
            {
                ObjectRg.useGravity = true;
                ObjectRg.freezeRotation = false;
                Object = null;
                ObjectRg = null;
            }
        }
    }
}
