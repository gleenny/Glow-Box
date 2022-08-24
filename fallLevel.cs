using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallLevel : MonoBehaviour
{
  public GameObject fallPoint;

    // Start is called before the first frame update
    void Start()
    {
        fallPoint = GameObject.Find("FallPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < fallPoint.transform.position.x) 
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}