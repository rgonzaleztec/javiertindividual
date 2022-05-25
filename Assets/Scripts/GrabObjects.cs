using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{
    public GameObject _objetoGrabed;
    public GameObject _jugador;




    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log(other.gameObject.name + "trigger GRAB");
        if (other.gameObject.tag == "Grab")
        {

            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.SetParent(_jugador.transform);
            other.gameObject.transform.position = _jugador.transform.position + new Vector3(0f, 2f, 0f);
            _objetoGrabed = other.gameObject;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "UnGrab")
        {
          //Debug.Log(collision.gameObject.name + "Colicion entro siiiii");
          _objetoGrabed.transform.SetParent(null);
          _objetoGrabed.gameObject.GetComponent<Rigidbody>().useGravity = true;
          _objetoGrabed.gameObject.GetComponent<Rigidbody>().isKinematic = false;
          _objetoGrabed.gameObject.transform.position = collision.transform.position + new Vector3(0,1f,0);
        }
    }


}
