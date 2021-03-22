using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    float velocidade = 5f;

    bool bolaLancada = false;

  

    // Update is called once per frame
    void Start()
    {
   
        if (Time.deltaTime >= 2f) bolaLancada = true;
        

            GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
        

    }
}
