using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulla : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;

    public int destActual;

    public NavMeshAgent miAgente;

    public float margen = 1;

    public GameObject jugador;
    public float rango = 3;

    public GameObject BalaEnemiga;
    public GameObject ArmaEnemiga;
    public bool bReady;
    public float fireRate = 0.5f;
    private float ultimoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        miAgente = this.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectarAlPlayer();
        RutaPatrulla();
    }
    void DetectarAlPlayer()
    {
        //Detectar al jugador
        Vector3 distPlayer = jugador.transform.position - this.transform.position;   //vector de jugador a la IA
        if (distPlayer.magnitude < rango)                                            //Comparar tamaño del vector con rango de deteccion
        {
            miAgente.SetDestination(jugador.transform.position);                    //Ir al jugador como nuevo destino
            if (ultimoDisparo < Time.time)
            {
                ultimoDisparo = Time.time + fireRate;
                GameObject g = Instantiate(BalaEnemiga, ArmaEnemiga.transform.position, ArmaEnemiga.transform.rotation);
                g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 1000);
            }

        }
    }
    

    void RutaPatrulla()
    {
        //Detectar la distancia al destino 
        //Distancia destino

        Vector3 dist = this.transform.position - miAgente.destination;
        if (dist.magnitude < margen)
        {
            //Llegamos al destino
            if (destActual == 1)
            {
                //Actualizar destino
                destActual = 2;
                //Mandar al punto 2
                miAgente.SetDestination(p2.transform.position);
            }
            else
            {
                destActual = 1;
                //Mandar al Punto 1
                miAgente.SetDestination(p1.transform.position);
            }
        }
    }

}
