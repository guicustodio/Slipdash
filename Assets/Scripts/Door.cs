using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newSprite;

    public void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        GameObject GameStatus = GameObject.Find("Game Status");
        GameStatus GS = GameStatus.GetComponent<GameStatus>();
        if (GS.currentScore >= 4)
        {
            SwitchSprite();
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject GameStatus = GameObject.Find("Game Status");
        GameStatus GS = GameStatus.GetComponent<GameStatus>();
        if (GS.currentScore >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void SwitchSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
