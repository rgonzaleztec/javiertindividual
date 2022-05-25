using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnGrabObjects : MonoBehaviour
{
    // Start is called before the first frame updat

    public GameObject _objetoGrabed;

private void OnTriggerEnter(Collider other)
{
    //Debug.Log(other.gameObject.name + "trigger un ungrab");
 
}

private void OnCollisionEnter(Collision other)
    {
     //Debug.Log(other.gameObject.name + "collision enter ungrab");
        foreach (ContactPoint contact in other.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }

}



