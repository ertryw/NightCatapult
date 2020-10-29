using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hightScore : MonoBehaviour
{
    Text hightscore;
    // Start is called before the first frame update
    void Start()
    {
        hightscore = GetComponent<Text>();
        hightscore.text = PlayerPrefs.GetInt("HightScores").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
