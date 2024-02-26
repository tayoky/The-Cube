using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class and : MonoBehaviour
{
    public int open;
    public int nb;
    public portes porte;
    // Start is called before the first frame update
    void Start()
    {
        open = 0;
        Debug.Log("compte");
    }

    // Update is called once per frame
    void Update()
    {
        porte.open = open >= nb;
    }
}
