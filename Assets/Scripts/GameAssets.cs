using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour { 


    public AudioClip catapultShot;
    public AudioClip WoodBrake;
    public AudioClip Fire;

    private static GameAssets _i;

    public static GameAssets Instance
    {
        get
        {
            if (_i == null)
                _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
