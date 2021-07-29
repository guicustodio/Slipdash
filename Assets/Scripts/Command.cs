using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(Animator anim);
}

public class PerformJump: Command
{
    public override void Execute(Animator anim)
    {
        anim.Play("Base Layer.Jumping", 0, 0f);
        anim.SetTrigger("isDashing");
    }
}

public class DoNothing: Command
{
    public override void Execute(Animator anim)
    {
        
    }
}