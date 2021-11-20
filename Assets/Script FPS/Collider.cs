using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public GameObject Bala;
    //Se crea el script para que desaparezcan las rocas 

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(other.gameObject);
            
        }
        else
        {
            Destroy(Bala);
        }
    }
}
