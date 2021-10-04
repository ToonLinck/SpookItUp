using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highscore : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI score;
    void Start()
    {
        score.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
