using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ifsafe : MonoBehaviour
{

    public GameObject obj;


    void Start()
    {
        if (PlayerPrefs.HasKey("vault"))
        {
            obj.SetActive(false);
            //PlayerPrefs.DeleteKey("vault");
        }
       
    }



}