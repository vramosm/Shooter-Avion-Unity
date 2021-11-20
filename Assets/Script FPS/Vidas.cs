using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public Image barra;
    public float maxVida = 100;
    public float vida = 100f; //la vida es 100

    private void Update()
    {
 
            float vidaParaImagen = (float)vida / maxVida;

            barra.fillAmount = vidaParaImagen;
    }

    void OnTriggerEnter(UnityEngine.Collider other) 
                                                    
    {
        if (other.gameObject.tag == "Bala")
        {
            vida -= 10; 
                        
            if (vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Botiquin")
        {
            vida += 10; 
            if (vida > 100)
            {
                vida = 100; 
            }
        }
    }

}
