using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public List<LineRenderer> meuLinerRenderer;
    public List<BoxCollider2D> meuCollider;
    public bool IsActive = false;

    private void Awake()
    {
        foreach (LineRenderer obj in meuLinerRenderer)
        {
            obj.enabled = false;
        }
        foreach (BoxCollider2D box in meuCollider)
        {
            box.enabled = false;
        }
    }

    private void Start()
    {
       StartCoroutine(Cast(2,2));
    }

    IEnumerator Cast(float ativalaser, float desativalaser)
    {
        IsActive = true;
        while (true)
        {
            foreach (LineRenderer obj in meuLinerRenderer)
            {
                obj.enabled = false;
            }
            foreach (BoxCollider2D box in meuCollider)
            {
                box.enabled = false;
            }

            yield return new WaitForSeconds(ativalaser);

            foreach (LineRenderer obj in meuLinerRenderer)
            {
                obj.enabled = true;
            }
            foreach (BoxCollider2D box in meuCollider)
            {
                box.enabled = true;
            }
            yield return new WaitForSeconds(desativalaser);

        }     
    }
}

