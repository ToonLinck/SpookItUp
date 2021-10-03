using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    bool dropped = false;

    public GameObject[] prefabs;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!dropped)
        {
            StartCoroutine(Waiter());
        }


    }

    void NewObject()
    {
        GameObject prefab = Instantiate(prefabs[Random.Range(0,prefabs.Length)]);
        prefab.GetComponent<MoveScript>().SetPos(gameObject.transform.position);


        StartCoroutine(MoveSet(prefab));

    }


    IEnumerator Waiter()
    {
        dropped = true;


        NewObject();

        yield return new WaitForSeconds(7);

        dropped = false;
    }

    IEnumerator MoveSet(GameObject pref)
    {
        pref.GetComponent<MoveScript>().SetMovable(true);
        yield return new WaitForSeconds(3);



            
        pref.GetComponent<MoveScript>().SetMovable(false);

    }
}
