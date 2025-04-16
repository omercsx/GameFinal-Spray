using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Vectors : MonoBehaviour
{
    public void FindShortest(int[][] vectors)
    {
        //  throw new NotImplementedException("Waiting to be implemented.");

        Debug.Log(" L1" + vectors.GetLength(0));
        Debug.Log(" L2" + vectors.GetLength(1));
       Debug.Log(" L3" + vectors.GetLength(2));
    }
    private void Start()
    {
        int[][] vectors =
       {
            new int[] { 1, 1, 1 },
            new int[] { 2, 2, 2 },
            new int[] { 3, 3, 3 }
        };

        FindShortest(vectors);
        // Expected output: x: 1, y: 1, z: 1
      //  Console.WriteLine(String.Format("x: {0}, y: {1}, z: {2}", shortest[0], shortest[1], shortest[2]));
    }
    /*  public static void Main(string[] args)
      {
          int[][] vectors =
          {
              new int[] { 1, 1, 1 },
              new int[] { 2, 2, 2 },
              new int[] { 3, 3, 3 }
          };

          int[] shortest = Vectors.FindShortest(vectors);
          // Expected output: x: 1, y: 1, z: 1
          Console.WriteLine(String.Format("x: {0}, y: {1}, z: {2}", shortest[0], shortest[1], shortest[2]));
      }*/
}
