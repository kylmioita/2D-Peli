using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;
    private Text text;
    private TextMeshProUGUI text2;

    void Start()
    {
        if (this.gameObject.tag == "GameScore")
        {
            text = GetComponent<Text>();
            score = 0;
        }
        else
        {
            text2 = GetComponent<TextMeshProUGUI>();
        }

    }

    void Update()
    {
        if (this.gameObject.tag == "GameScore")
        {
            this.gameObject.SetActive(!Health.dead);

            if (Health.dead)
            {
                return;
            }
            text.text = score.ToString() + "/100";
        }
        else
        {
            text2.text = "score: " + score.ToString();
        }
    }
}
