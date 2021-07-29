using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyCoin();
    }

    private void DestroyCoin()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        Destroy(this.gameObject);
    }
}
