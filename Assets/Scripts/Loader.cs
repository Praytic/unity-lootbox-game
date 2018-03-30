using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    public GameObject gameControl;
    
	void Awake ()
    {
        Debug.Log("Loader Awake.");
        if (GameControl.instance == null) Instantiate(gameControl);
	}
}
