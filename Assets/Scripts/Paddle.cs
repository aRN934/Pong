using UnityEngine;

public class Paddle : MonoBehaviour
{

    // não fazemos assim
    // int velocidade = 1;
    // porque é número inteiro e não dá jeito para velocidade
    //acrescentar um serializefield para aparecer a variável de velocidade no editor do unity
    [SerializeField]
    float velocidade = 0.5f;

    
    //para se escolher as teclas dif no jogo, serialize as teclas

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;


    // Update is called once per frame
    void Update()
    {
        /*
         * Lógica:
         * se tecla premida -> então subir
         * senão se tecla para baixo premida -> então descer
         */

        //if (Input.GetKey(KeyCode.UpArrow))
        if (Input.GetKey(upKey))
        {
            // Sobe
            // Se fosse no unity, íamos no inspector ao "transform", depois "position", depois ao eixo y
            // portanto
            // transform.position = transform.position + velocidade * Vector3.up; -> limpar com +=
            // depois acrescentar Time.deltaTime para o jogo correr a tempo e não a ciclos de refresh

            transform.position += velocidade * Vector3.up * Time.deltaTime;
        }
        //else if (Input.GetKey(KeyCode.DownArrow))
        else if (Input.GetKey(downKey))
        {
            //Desce
            transform.position += velocidade * Vector3.down * Time.deltaTime;
        }

        //agora paa impor limites, dizemos que o pivot da paddle quando chega ao limite da câmara volta atrás
        //ou seja, no eixo y quando a altura é maior ou igual a 3 (unidades unity) - metade do tamanho da paddle (altura do pivot, para nada ficar cortado)
        // recambiamos o bicho para a última posição possível (altura total da câmara - altura do pivot da paddle)

        float cameraHeight = Camera.main.orthographicSize;
        float halfPaddleSize = 0.5f;

        //if(transform.position.y >= cameraHeight - halfPaddleSize)
        //{
        //    //  transform.position.y = 3f - 0.5f;
        //    //não funciona porque não podemos alterar numeros individuais no transform.position
        //    //portanto usamos Vector3 como auxiliar
        //    //depois para substituir os números mágicos (repetidos 3 e 0.5) fazemos um float
        //    //float com o 3 da camara ou Camera.main.ortographicSize
        //    //e assim a câmara pode ser alterada que o código substitui na mesma

        //    Vector3 positionAux = transform.position;
        //    positionAux.y = cameraHeight - halfPaddleSize;
        //    transform.position = positionAux;
        //}
        //if (transform.position.y <= -cameraHeight + halfPaddleSize)
        //{
        //    Vector3 positionAux = transform.position;
        //    positionAux.y = -cameraHeight + halfPaddleSize;
        //    transform.position = positionAux;
        //}

        //há outra forma de fazer, com clamp (fourchette)
        Vector3 positionAux = transform.position;
        positionAux.y = 
        Mathf.Clamp(transform.position.y, -cameraHeight + halfPaddleSize, cameraHeight - halfPaddleSize);
        transform.position = positionAux;

    }
}
