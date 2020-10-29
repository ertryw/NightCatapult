using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int GameScene;

    ScreenFader sf;
    public FloatReference s_scores;
    public FloatReference s_bullets;
    public FloatReference s_stage;
    public Rigidbody2D bullet;
    public UnityEvent reload_catapult;
    public AudioClip click;
    public AudioSource audisource;
    // Start is led before the first frame update
    void Start()
    {
        if (GameScene == 0)
        {
            s_scores.Variable.Value = 0;
            s_bullets.Variable.Value = 0;
            s_stage.Variable.Value = 0;
            Screen.SetResolution(1600, 900, true, 60);
        }

        if (GameScene == 1)
        {
            SceneStart();
        }
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("HightScores", Convert.ToInt32(s_scores.Variable.Value));
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameScene == 1)
        {
            audisource = GameObject.Find("AudioSource1").GetComponent<AudioSource>();
            EtapConditions();
            InputKeys();
        }
    }

    void SceneStart()
    {
        sf = GameObject.FindObjectOfType<ScreenFader>();
        if (sf == null)
            Debug.LogError("ScreenFader!");

        s_bullets.Variable.Value += 3;
    }

    void InputKeys()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            EndScene();
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            reload_catapult.Invoke();
        }

    }

    public void ExitGame()
    {
        audisource.PlayOneShot(click);
        Application.Quit();
    }
    public void LoadGame()
    {
        audisource.PlayOneShot(click);
        SceneManager.LoadScene(1);
    }

    void EtapConditions()
    {

        if (s_bullets.Variable.Value == 0 && bullet.velocity.sqrMagnitude <= 0.01f)
        {
            EndScene();
        }
    }

    public void EndScene()
    {
        print(sf.sceneStarting);
        if (sf.sceneEnding == false)
        {
            print("next");
            sf.EndScene(1);
            s_stage.Variable.Value += 1;
        }
    }


}
