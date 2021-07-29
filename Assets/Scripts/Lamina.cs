using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamina : MonoBehaviour
{

    public float speedVertical;

    void Update()
    {
        MovimentoVertical();
    }

    void MovimentoVertical()
    {
        transform.Translate(0, speedVertical * Time.deltaTime, 0);

        if (transform.position.y >= 10)
        {
            speedVertical = -10;
        }
        if (transform.position.y <= -10)
        {
            speedVertical = 10;
        }
    }
}
