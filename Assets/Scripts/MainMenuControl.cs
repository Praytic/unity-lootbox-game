using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MainMenuControl : MonoBehaviour {

    public List<string> possibleSubtitles;

    public string GetRandomSubtitle()
    {
        Debug.Log("MainMenuControl GetRandomSubtitle.");
        return possibleSubtitles[Random.Range(0, 4)];
    }

    void Awake()
    {
        Debug.Log("MainMenuControl Awake.");
        possibleSubtitles = new List<string> { "Subtitle 1", "Subtitle 2", "Subtitle 3", "Subtitle 4" };
    }
}
