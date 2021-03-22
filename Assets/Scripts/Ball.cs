using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    float velocidade = 5f;

    float paradinha = 1f;
    bool bolaLancada = false;
    


    // Update is called once per frame
    void Update()
    {
        //QUERO DIZER
        //se >=2 segundos passaram verdadeiro - GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;


        if (Time.deltaTime <= 2f) bolaLancada = false;
         {
            //QUERO DIZER
            //A BOLA NÃO MEXE - LOL NÃO SEI ESCREVER ISTO



            GetComponent<Rigidbody2D>().velocity = paradinha * Random.insideUnitSphere;

         }
        //AAAACHAVA QUE FAZIA SENTIDO MAS AFINAL A BOLA NÃO MEXE DE TODO
        if (bolaLancada == true)
        {
            //*Ana se te der a burrice, já escreveste no onenote a lógica disto

            //if (Random.value < 0.5f)
            //{
            //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
            //}
            //else
            //{
            //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
            //}

            GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
        }

    }
}
