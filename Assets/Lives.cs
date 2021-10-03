using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update

    int lives = 3;
    Animator skelAnim;


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

        if (lives > 0)
        {
            lives--;
        }
        else
        {
            //Die()
        }

    }

}
