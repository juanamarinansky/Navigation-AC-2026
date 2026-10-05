using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] edades = new int[4];

    // Start is called before the first frame update
    void Start()
    {
        edades[0] = Random.Range(0, 11);
        edades[2] = 46;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearArray(edades);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SquareOfIndex(edades);
        }
    }

    void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    void SquareOfIndex(int[] array)
    {
        //asignar a cada posión el cuadrado de su índice
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * i;
        }
    }

    void RandomNumbers(int[] array)
    {
        //asigna valores aleatorios entre un máximo y un mínimo
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(0, 11);
        }
    }
}
