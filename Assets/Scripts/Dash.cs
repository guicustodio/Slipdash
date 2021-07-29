using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Dash : MonoBehaviour
{
    [SerializeField] private float dashForce;
    [SerializeField] private float dashDuration;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject player;
    [SerializeField] private List<GameObject> limits;
    [SerializeField] private Animator animator;

    [SerializeField] private float jumpVelocity;
    [SerializeField] private bool trava = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (rb.velocity.y < 0)
        {
            animator.SetBool("isFalling", true);
            animator.SetBool("isJumping", false);
            animator.SetBool("isGrounded", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && trava == true)
        {
            StartCoroutine(DashTime());
        }

        if (Input.GetKeyDown(KeyCode.Space) && trava == true)
        {
            rb.velocity = Vector2.up * jumpVelocity;
            animator.SetBool("isJumping", true);
            animator.SetBool("isFalling", false);
            animator.SetBool("isGrounded", false);
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2) //Direita
            {
                rb.AddForce(new Vector2(dashForce, player.transform.position.y));
                rb.velocity = Vector2.zero;
                trava = false;
            }
            else if (touch.position.x < Screen.width / 2 && trava == true) //Esquerda 
            {
                rb.velocity = Vector2.up * jumpVelocity;
            }
        }
    }

    IEnumerator DashTime()
    {
        rb.AddForce(new Vector2(dashForce, player.transform.position.y));
        animator.SetBool("isDashing", true);
        animator.SetBool("isGrounded", false);
        trava = false;
        //animator.Play("Base Layer.Dashing", 0, 0.25f);
        yield return new WaitForSeconds(dashDuration);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (rb.velocity.y == 0 && trava == true)
        {
            animator.SetBool("isGrounded", true);
            animator.SetBool("isFalling", false);
        }
        if (col.gameObject.name == "Tilemap")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (col.gameObject.name == "Cristal") 
        {
            SceneManager.LoadScene("SampleScene");
        }
        trava = true;
        if (col.gameObject.name == "Bar00")
        {
            player.transform.position = new Vector2(-15.3f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[0]);
        }
        if (col.gameObject.name == "Bar01")
        {
            player.transform.position = new Vector2(-9.3f, player.transform.position.y);
           animator.SetBool("isDashing", false);
            Destroy(limits[1]);
        }
        if (col.gameObject.name == "Bar02")
        {
            player.transform.position = new Vector2(-3.3f, player.transform.position.y);
           animator.SetBool("isDashing", false);
            Destroy(limits[2]);
        }
        if (col.gameObject.name == "Bar03")
        {
            player.transform.position = new Vector2(2.9f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[3]);
        }
        if (col.gameObject.name == "Bar04")
        {
            player.transform.position = new Vector2(8.6f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[4]);
        }
        if (col.gameObject.name == "Bar05")
        {
            player.transform.position = new Vector2(14.7f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[5]);
        }
        if (col.gameObject.name == "Bar06")
        {
            player.transform.position = new Vector2(20.7f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[6]);
        }
    }
}
