using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : MonoBehaviour
{
    public bool isPlayerinsign;
    public GameObject mom;
    public GameObject Spawn;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (isPlayerinsign ==true)
        {
            mom.SetActive(true);
        }
        if (isPlayerinsign == false)
        {
            mom.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerinsign = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mom.transform.position = Spawn.transform.position;
            isPlayerinsign = false;
        }
    }

}
