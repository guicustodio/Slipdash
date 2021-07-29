using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    Command keySpace, keyArrow;
    
    void Start()
    {
        keySpace = new PerformJump();
        keyArrow = new DoNothing();
        anim = actor.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            keyArrow.Execute(anim);
        }
    }
}
