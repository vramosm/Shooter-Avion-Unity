using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    //Referencia del jugador
    public GameObject jugador;

    //Distancia del jugador

    public float distDeteccion;

    //referencia componente nasmeshagent
    public NavMeshAgent miAgente;


    public float rango = 7;

    public GameObject BalaEnemiga;
    public GameObject ArmaEnemiga;
    public bool bReady;
    public float fireRate = 0.5f;
    private float ultimoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        //Obetenemos la referencia del componente
        miAgente = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direccion;
        direccion = jugador.transform.position - this.transform.position;

        //Condicion de distancia

        if (direccion.magnitude < distDeteccion)
        {
            //Seguir al jugador
            miAgente.SetDestination(jugador.transform.position);
        }

        DetectarAlPlayer();
    }

    void DetectarAlPlayer()
    {
        //Detectar al jugador
        Vector3 distPlayer = jugador.transform.position - this.transform.position;   //vector de jugador a la IA
        if (distPlayer.magnitude < rango)                                            //Comparar tamaño del vector con rango de deteccion
        {
            if (ultimoDisparo < Time.time)
            {
                ultimoDisparo = Time.time + fireRate;
                GameObject g = Instantiate(BalaEnemiga, ArmaEnemiga.transform.position, ArmaEnemiga.transform.rotation);
                g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 1000);
            }

        }
    }

}
