using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoDisparo : MonoBehaviour
{

    public GameObject efectoOriginal;
    public GameObject Bala;
    public GameObject Arma;
    public bool bReady;
    public float fireRate = 0.5f;
    private float ultimoDisparo;
    public AudioSource elSonido;

    // Start is called before the first frame update
    void Start()
    {
        elSonido.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            elSonido.Play();
            if (ultimoDisparo < Time.time)
            {
                ultimoDisparo = Time.time + fireRate;
                GameObject g = Instantiate(Bala, Arma.transform.position, Arma.transform.rotation);
                g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 1000);
            }
            //Disparo
            DispararConRayo();
        }
        
    }

    void DispararConRayo()
    {
        RaycastHit resultRayo;
        if (Physics.Raycast(this.transform.position, this.transform.forward, out resultRayo, 100))
        {

            Debug.Log(resultRayo.transform.name);
            Instantiate(efectoOriginal,resultRayo.point, this.transform.rotation);


            //Destruir

            if (resultRayo.transform.tag == "Enemy")
            {
                Destroy(resultRayo.transform.gameObject);
            }
        }
        else
        {
            Debug.Log("Rayo no colisiona");

        }

    }
}
