using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject efectoOriginal;
    public GameObject Fin;
    public bool tengoLlave;

    void OnTriggerEnter(UnityEngine.Collider other)
    {

        if (other.gameObject.tag == "Llave")
        {
            tengoLlave = true;
            Debug.Log("¡TIENES LA LLAVE!");

            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Puerta" && tengoLlave == true)
        {
            Debug.Log("¡TU PRINCESA ESTA EN OTRO CASTILLO!");
            Destroy(other.gameObject);
            Instantiate(efectoOriginal,Fin.transform.position,Fin.transform.rotation);
        }
    }
}
