using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    // Start is called before the first frame update
    public plateforme plate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        plate.open = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        plate.open = false;
    }
}
