using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    //começámos por string, passámos para int e acabámos com enumerações
    //criar enumeração - Left é 1, Right é 2 por ser enum
    //assim não é necessário ser int para 1 e 2, fica menos confuso

    public enum WallName { Left , Right }

    [SerializeField]
    ScoreKeeper scoreKeeper;

    [SerializeField]
    WallName lado = WallName.Left;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Quando a bola bater avisar ScoreKeeper para aumentar +1

        scoreKeeper.Goal(lado);



    }

}
