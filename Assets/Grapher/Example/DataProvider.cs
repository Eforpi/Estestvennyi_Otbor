using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataProvider : MonoBehaviour
{

    // Ignore this line.
    public float t = 0;

    void Update()
    {

        Grapher.Log(t, "Cos1", Color.yellow);
    }

    public enum TestEnum
    {
        bird, horse, alien
    }
}
