using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;

    void Start()
    {
        if (this.gameObject.tag == "GameScore")
        {
            score = 0;
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
        }

        GetComponent<UnityEngine.UI.Text>().text = (this.gameObject.tag == "GameScore"? "": "Score: ") + score.ToString();
    }
}
