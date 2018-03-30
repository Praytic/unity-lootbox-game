using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    
    public static GameControl instance = null;          
    
    public MainMenuControl mainMenuCtrl;                       
    
    void Awake()
    {
        Debug.Log("GameControl Awake.");
        if (instance == null)
            instance = this;
        
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        mainMenuCtrl = GetComponent<MainMenuControl>();
        Debug.Log(mainMenuCtrl);
    }
}
