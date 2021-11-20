using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image barra;

    public int maxVida = 100;
    public int vida = 100;

    private void Start()
    {
        maxVida = 100;
        vida = maxVida;
    }
    private void Update()
    {
        ActualizarBarra();

        void OnCollisionEnter(Collision other)

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
                Destroy(other.gameObject);
            }

        }
    }

    void ActualizarBarra()
    {
        float vidaParaImagen = (float)vida / maxVida;

        barra.fillAmount = vidaParaImagen;
    }
}
