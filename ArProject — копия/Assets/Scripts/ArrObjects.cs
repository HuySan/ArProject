﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrObjects : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject[] texts;

    int indexFlag;

    void Start()
    {
        objects[indexFlag].SetActive(true);
        texts[indexFlag].SetActive(true);
    }

    public void OnMouseRight()
    {
        objects[indexFlag].SetActive(false);
        texts[indexFlag].SetActive(false);
        indexFlag++;
        if (indexFlag >= objects.Length)
        {
            indexFlag = 0;
        }
        objects[indexFlag].SetActive(true);
        texts[indexFlag].SetActive(true);
       
    }



    public void OnMouseLeft()
    {
        objects[indexFlag].SetActive(false);
        texts[indexFlag].SetActive(false);
        indexFlag--;
        if (indexFlag < 0)
        {
            indexFlag = objects.Length - 1;
        }
        objects[indexFlag].SetActive(true);
        texts[indexFlag].SetActive(true);
    }



}