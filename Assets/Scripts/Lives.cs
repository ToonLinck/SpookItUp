using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update

    int lives = 3;
    Animator skelAnim;
    public RawImage[] liveIcons;
    public TextMeshProUGUI pointsText;
    int points = 0;


    void Start()
    {
        skelAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        skelAnim.SetInteger("Lives", lives);
    }

    public void LivesDown()
    {

        if (lives > 1)
        {
            lives--;
            updateIcons();
        }
        else
        {
            Time.timeScale = 0;
            if (points > PlayerPrefs.GetInt("Highscore",0))
            {
                PlayerPrefs.SetInt("Highscore",points);
            }
            PlayerPrefs.SetInt("Score",points);

            SceneManager.LoadScene("EndScreen");
        }

    }

    void updateIcons()
    {

        switch(lives)
        {
            case 0:

                liveIcons[0].enabled = false;
                liveIcons[1].enabled = false;
                liveIcons[2].enabled = false;

                break;
            case 1:
                liveIcons[0].enabled = true;
                liveIcons[1].enabled = false;
                liveIcons[2].enabled = false;
                break;
            case 2:
                liveIcons[0].enabled = true;
                liveIcons[1].enabled = true;
                liveIcons[2].enabled = false;
                break;
            case 3:
                liveIcons[0].enabled = true;
                liveIcons[1].enabled = true;
                liveIcons[2].enabled = true; 
                break;

        }

    }


    public void AddPoint()
    {

        points++;
        pointsText.text = points.ToString();

    }


    public void RemovePoint()
    {

        if (points > 0)
        {

            points--;
            pointsText.text = points.ToString();
        } 

    }

}
