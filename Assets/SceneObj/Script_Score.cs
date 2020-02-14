using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Score : MonoBehaviour
{
    public Text score;
    public GameObject Spawner;
    private bool addSpawner = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreKeeper = GameObject.Find("ScoreCounter");
        score = scoreKeeper.GetComponent<Text>();
        score.text = "0";

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (int.Parse(score.text)%100 == 0 && addSpawner && int.Parse(score.text)!=0)
        {
            addSpawner = false;
            GameObject newSpawner = Instantiate<GameObject>(Spawner);
            newSpawner.transform.position = transform.position;
        }
        else if (int.Parse(score.text)%100 != 0)
        {
            addSpawner = true;
        }
    }
}
