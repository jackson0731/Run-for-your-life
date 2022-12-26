using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    public GameObject Window;

    public void Load()
    {
        SceneManager.LoadScene("Level");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Window.GetComponent<Animation>().Play("DeadFadeout");
        }
    }
}
