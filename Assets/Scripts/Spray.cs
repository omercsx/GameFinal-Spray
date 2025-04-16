using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour
{
    public Color[] myColor;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.sprayColor = GetRandomColour(Random.Range(0, myColor.Length));
        Invoke(nameof(SprayBottles), 0.5f);
    }
    void SprayBottles()
    {
        GameManager.instance.SprayAllBlocks();
    }
    private Color GetRandomColour(int index)
    {
        return new Color(myColor[index].r, myColor[index].g, myColor[index].b, 255);
    }
}
