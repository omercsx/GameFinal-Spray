using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public SpriteRenderer vfx;
    /*[HideInInspector] */public bool colored = true;

    private void Start()
    {
        colored = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!colored)
            return;



        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            if (GameManager.instance.gotSpray)
            {
                vfx.color = GameManager.instance.defaultColor;
                colored = false;
                GameManager.instance.CheckColorBlocks();
            }
        }
    }
}
