using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascenseur : MonoBehaviour
{
    public GameObject Ascenseur;
    public float speed,max;
    private bool activate;
    private void OnTriggerEnter(Collider other)
    {
        activate = true;
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void Update()
    {
        if (activate)
        {
            Ascenseur.transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (Ascenseur.transform.position.y > max)
            {
                Ascenseur.transform.Translate(Vector3.up * (max - Ascenseur.transform.position.y));
            }
        }
    }
}
