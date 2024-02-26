using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateforme : MonoBehaviour
{
    public bool open = false;
    public float speed;
    public float max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open) this.transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (this.transform.position.y > max) this.transform.Translate(new Vector3(0,max - this.transform.position.y,0));
    }
}
