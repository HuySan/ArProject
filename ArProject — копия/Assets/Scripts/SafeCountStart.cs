using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCountStart : MonoBehaviour {
	void Start () {
        PlayerPrefs.SetInt("vault", 1);
    }

}
