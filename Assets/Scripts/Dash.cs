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

    [SerializeField] private float FallingThreshold = 0;
    private bool Falling = false;

    private CircleCollider2D circleCollider;

    [SerializeField] private LayerMask groundLayerMask;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        PlayerMovement();
        CheckIfFalling();
        CheckIfGrounded();
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.Raycast(circleCollider.bounds.center, -Vector2.up, circleCollider.bounds.extents.y + 0.5f, groundLayerMask);
        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        //Debug.DrawRay(transform.position, -Vector2.up * (circleCollider.bounds.extents.y + 0.5f), rayColor);
        //Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }

    void CheckIfGrounded()
    {
        if (IsGrounded())
        {
            animator.SetBool("isGrounded", true);
            animator.SetBool("isFalling", false);
        }
    }
    void CheckIfFalling()
    {
        if (rb.velocity.y < FallingThreshold)
        {
            Falling = true;
        }
        else
        {
            Falling = false;
        }
        if (Falling)
        {
            IsFalling();
        }
    }

    void IsFalling()
    {
        animator.SetBool("isFalling", true);
        animator.SetBool("isJumping", false);
        animator.SetBool("isGrounded", false);
    }
    void PlayerMovement()
    {
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
                StartCoroutine(DashTime());
            }
            else if (touch.position.x < Screen.width / 2 && trava == true) //Esquerda 
            {
                rb.velocity = Vector2.up * jumpVelocity;
                animator.SetBool("isJumping", true);
                animator.SetBool("isFalling", false);
                animator.SetBool("isGrounded", false);
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

        if (col.gameObject.name == "Tilemap")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        trava = true;
        if (col.gameObject.name == "Bar00")
        {
            player.transform.position = new Vector2(-15.5f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[0]);
        }
        if (col.gameObject.name == "Bar01")
        {
            player.transform.position = new Vector2(-9.5f, player.transform.position.y);
           animator.SetBool("isDashing", false);
            Destroy(limits[1]);
        }
        if (col.gameObject.name == "Bar02")
        {
            player.transform.position = new Vector2(-3.5f, player.transform.position.y);
           animator.SetBool("isDashing", false);
            Destroy(limits[2]);
        }
        if (col.gameObject.name == "Bar03")
        {
            player.transform.position = new Vector2(2.5f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[3]);
        }
        if (col.gameObject.name == "Bar04")
        {
            player.transform.position = new Vector2(8.5f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[4]);
        }
        if (col.gameObject.name == "Bar05")
        {
            player.transform.position = new Vector2(14.4f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[5]);
        }
        if (col.gameObject.name == "Bar06")
        {
            player.transform.position = new Vector2(20.4f, player.transform.position.y);
            animator.SetBool("isDashing", false);
            Destroy(limits[6]);
        }
    }
}
