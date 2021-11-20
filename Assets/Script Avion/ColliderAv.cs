using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderAv : MonoBehaviour
{
    public float ContadorEsferas;
    public GameObject Avion;
    //Se crea el script para que desaparezcan las esferas 

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Esfe")
        {
            ContadorEsferas++;
            Debug.Log("Esferas conseguidas:" + ContadorEsferas);
            Destroy(other.gameObject);

        }

       if (other.gameObject.tag == "Suelo")
        {
            Destroy(Avion);
        }

    }
}
