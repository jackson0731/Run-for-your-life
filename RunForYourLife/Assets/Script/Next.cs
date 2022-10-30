using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public GameObject[] image;
    public float i;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && i == 0)
        {
            image[0].GetComponent<Animation>().Play("Fadein");
            i++;
        }else if(Input.GetKeyDown(KeyCode.Space) && i == 1)
        {
            image[1].GetComponent<Animation>().Play("Fadein");
            i++;
        }else if(Input.GetKeyDown(KeyCode.Space) && i == 2) 
        {
            image[2].GetComponent<Animation>().Play("Fadein");
            i++;
        }else if (Input.GetKeyDown(KeyCode.Space) && i == 3) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Start()
    {
        i = 0;
    }
}
