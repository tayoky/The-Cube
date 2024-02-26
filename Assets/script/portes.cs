using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portes : MonoBehaviour
{
    public bool open;
    public float speed;
    public GameObject porte1, porte2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            porte1.transform.localPosition =new Vector3(0,0,porte1.transform.localPosition.z - speed * Time.deltaTime);
            if (porte1.transform.localPosition.z < -1.25f) porte1.transform.localPosition = new Vector3(0, 0, -1.25f);
            porte2.transform.localPosition = new Vector3(0, 0, porte2.transform.localPosition.z + speed * Time.deltaTime);
            if (porte2.transform.localPosition.z > 1.25f) porte2.transform.localPosition = new Vector3(0, 0, 1.25f);
        }
        else
        {
            porte1.transform.localPosition = new Vector3(0, 0, porte1.transform.localPosition.z + speed * Time.deltaTime);
            if (porte1.transform.localPosition.z > -0.5f) porte1.transform.localPosition = new Vector3(0, 0, -0.5f);
            porte2.transform.localPosition = new Vector3(0, 0, porte2.transform.localPosition.z - speed * Time.deltaTime);
            if (porte2.transform.localPosition.z < 0.5f) porte2.transform.localPosition = new Vector3(0, 0, 0.5f);
        }
    }
}
