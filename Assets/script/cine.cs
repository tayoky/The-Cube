using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class cine : MonoBehaviour
{
    public GameObject[] point;
    public float speed;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(point[i].transform);
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if ((this.transform.position - point[i].transform.position).magnitude < speed * Time.deltaTime)
        {
            i++;
            if(i > point.Length - 1) Destroy(this);
        }
    }
}
