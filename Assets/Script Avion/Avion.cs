using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    public float Temp;
    public float Speed;
    public float SpeedRot;
    public GameObject Bala;
    public GameObject Cañon;
    public bool bReady;
    public float fireRate = 0.5f;
    private float ultimoDisparo;

    // Start is called before the first frame update
    void Start()
    {

        ultimoDisparo = Time.time;
        Debug.Log("USA LOS BOTONES Q Y E PARA HACER GIROS");
    }

    // Update is called once per frame
    void Update()
    {

        //Se crean los movimientos y el disparo del tanque con la condicion de estar dentro del tiempo
        if (this.GetComponent<ColliderAv>().ContadorEsferas < 4)
        {
            transform.Translate(new Vector3(0, 0, 2) * Speed * Time.deltaTime, Space.Self);

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, -20, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 20, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(new Vector3(-30, 0, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(new Vector3(30, 0, 0) * SpeedRot * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(new Vector3(0, 0, 30f) * SpeedRot * Time.deltaTime, Space.Self);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(new Vector3(0, 0, -30f) * SpeedRot * Time.deltaTime, Space.Self);
            }

            // Se crea el disparo, configurando el rate, la cadencia y la trayqectoria del disparo
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (ultimoDisparo < Time.time)
                {
                    ultimoDisparo = Time.time + fireRate;
                    GameObject g = Instantiate(Bala, Cañon.transform.position, Cañon.transform.rotation);
                    g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 10000);
                }

            }
        }
        else
        {
            End();

        }
    }
    void End()
    {
        //se crea este apartado para que salga en la consola, poniendo el destroy para que solo salga una vez el mensaje
        Debug.Log("¡Mision Completada!");
        Destroy(this);
    }
}
