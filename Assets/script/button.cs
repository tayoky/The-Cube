using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public portes porte;
    public and ands;
    public GameObject but;
    private float speed = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("button pressed");
        if (other.gameObject.tag != "ignore")
        {
            if (porte != null) porte.open = true;
            else if (ands != null) ands.open++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("button depressed");
        if (other.gameObject.tag != "ignore")
        {
            if (porte != null) porte.open = false;
            else if (ands != null) ands.open--;
        }
    }

    private void Update()
    {
        if (porte != null)
        {
            if (!porte.open)
            {
                but.transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            else
            {
                but.transform.Translate(Vector3.up * Time.deltaTime * -speed);
            }

            if (but.transform.localPosition.y < 0)
            {
                but.transform.localPosition = Vector3.zero;
            }

            if (but.transform.localPosition.y > 0.125f)
            {
                but.transform.localPosition = Vector3.up * 0.125f;
            }
        }
    }
}
