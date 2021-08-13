using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 0.5f;
    Vector2 offset;

    Material m_Material;

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        
    }

    void Update()
    {
        offset = new Vector2(speed, 0);
        m_Material.mainTextureOffset += offset * Time.deltaTime;

    }
}
