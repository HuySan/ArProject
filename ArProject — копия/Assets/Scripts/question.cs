using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour {
    public GameObject obj;
    public Button exitOff;


    public void OnMouseDown()
        {
//Тут будет имя тега с инфой
            obj.SetActive(true);
            exitOff.interactable = false;
            PlayerPrefs.SetInt("vault",1);
    }
    public void ExitWindow()
        {
            obj.SetActive(false);
            exitOff.interactable = true;
    }
}
