using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Color sprayColor;
    public Color defaultColor;
    public bool gotSpray;
    public bool allcolored;
    public string nextLevel;
    private void Awake() => instance = this;

    public Blocks[] blocks;
    // Start is called before the first frame update
    void Start()
    {
        defaultColor = Color.white;
        blocks = GameObject.FindObjectsOfType<Blocks>();
    }

    public void CheckColorBlocks()
    {
        for (int i = 0; i < blocks.Length; i++)
        {
            if (blocks[i].colored)
            {
                allcolored = false;
                return;
            }
            else
            {
                allcolored = true;
            }
        }

        if (allcolored)
        {
            NextLevel();
        }
    }

    public void SprayAllBlocks()
    {
        foreach(Blocks block in blocks)
            block.vfx.color = sprayColor;
        Debug.Log("all blocks are sprayed");
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
