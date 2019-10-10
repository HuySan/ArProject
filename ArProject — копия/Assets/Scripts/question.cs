using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour {
    public GameObject obj;
    public Button[] buttons;


    public void OnMouseX()
        {
//Тут будет имя тега с инфой
            obj.SetActive(true);
            for (int key = 0; key < buttons.Length; key++) {
                buttons[key].interactable = false;
            }
    }
    public void ExitWindow()
        {
            obj.SetActive(false);
            PlayerPrefs.SetInt("vault", 1);
            for (int key = 0; key < buttons.Length; key++)
            {
                buttons[key].interactable = true;
            }
    }
}
