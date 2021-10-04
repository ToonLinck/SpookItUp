using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    bool dropped = false;
    public GameObject skel;
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
        GameObject prefab2 = Instantiate(prefab);
        prefab.GetComponent<MoveScript>().SetPos(gameObject.transform.position);
        prefab2.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0.5f);
        prefab2.GetComponent<MoveScript>().SetPos(new Vector2(gameObject.transform.position.x,gameObject.transform.position.y -2));
        prefab.GetComponent<Rigidbody2D>().rotation = Random.Range(0, 360);
        prefab2.GetComponent<Rigidbody2D>().rotation = prefab.GetComponent<Rigidbody2D>().rotation;
        
        StartCoroutine(MoveSet(prefab,prefab2));

    }


    IEnumerator Waiter()
    {
        dropped = true;


        NewObject();

        yield return new WaitForSeconds(7);

        dropped = false;
    }

    IEnumerator MoveSet(GameObject pref, GameObject pref2)
    {
        pref.GetComponent<MoveScript>().SetMovable(true);
        yield return new WaitForSeconds(3);



        Destroy(pref2);
        skel.GetComponent<Lives>().AddPoint();
        pref.GetComponent<MoveScript>().SetMovable(false);

    }
}
