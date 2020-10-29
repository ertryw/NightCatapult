using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    public GameObject[] stages;
    public FloatReference stage;
    public FloatReference s_scores;
    public Text stageTxt;
    public Text endstageTxt;
    public ScreenFader sf;
    public GameController gc;
    public GameObject EndPanel;
    public Text HightScore;
    // Start is called before the first frame update
    void Start()
    {
        sf = GetComponent<ScreenFader>();
        endstageTxt.text = (stages.Length - 1).ToString();
    }




    // Update is called once per frame
    void Update()
    {
        stageTxt.text = stage.Variable.Value.ToString();

        if (stage.Variable.Value == stages.Length)
        {
            EndPanel.LeanMoveY(500,1f);

           int hight = PlayerPrefs.GetInt("HightScores");

            if (s_scores.Variable.Value > hight)
                gc.SaveGame();

            HightScore.text = hight.ToString();
        }

        if (stage.Variable.Value > stages.Length )
        {
            stage.Variable.Value = 0;
            s_scores.Variable.Value = 0;
        }

        if (stage.Variable.Value != stages.Length)
        {
            EndPanel.LeanMoveY(1800, 1f);
        }

        if (sf.sceneStarting == true)
        {
            for (int i = 0; i < stages.Length; i++)
            {
                if (stage.Variable.Value != i)
                {
                    stages[i].SetActive(false);
                }

                if (stage.Variable.Value == i)
                {
                    stages[i].SetActive(true);
                }

            }
        }
    }

}
