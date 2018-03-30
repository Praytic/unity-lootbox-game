using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitle : MonoBehaviour
{
    Text content;
    
	void Start ()
    {
        Debug.Log("Subtitle Start.");
        content = GetComponent<Text>();
        var mainMenuCtrl = GameControl.instance.mainMenuCtrl;
        content.text = mainMenuCtrl.GetRandomSubtitle();
    }
}
