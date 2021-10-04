using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI score;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("Score",0).ToString();
        PlayerPrefs.DeleteKey("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
