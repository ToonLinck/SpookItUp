using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update

    int lives;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
