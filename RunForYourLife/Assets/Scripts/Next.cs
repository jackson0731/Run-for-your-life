using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public GameObject[] image;
    public int i = 0;

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "1")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[0].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                image[3].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 5)
            {
                image[4].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 6)
            {
                image[5].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 7)
            {
                image[6].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 8)
            {
                image[7].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 9)
            {
                i = 0;
                SceneManager.LoadScene("2");
            }
        }
        if (sceneName == "2")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[0].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                i = 0;
                SceneManager.LoadScene("3");
            }
        }
        if (sceneName == "3")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[0].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                image[3].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 5)
            {
                image[4].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 6)
            {
                image[5].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 7)
            {
                i = 0;
                SceneManager.LoadScene("Level");
            }
        }
        if (sceneName == "END1")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[3].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                image[4].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 5)
            {
                image[5].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 6)
            {
                image[6].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 7)
            {
                image[7].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 8)
            {
                image[8].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 9)
            {
                image[9].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 10)
            {
                i = 0;
                SceneManager.LoadScene("END2");
            }
        }
        if (sceneName == "END2")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[3].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                image[4].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 5)
            {
                image[5].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 6)
            {
                image[6].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 7)
            {
                image[7].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 8)
            {
                i = 0;
                SceneManager.LoadScene("END3");
            }
        }
        if (sceneName == "END3")
        {
            if (Input.anyKeyDown && i == 1)
            {
                image[1].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 2)
            {
                image[2].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 3)
            {
                image[3].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 4)
            {
                image[4].GetComponent<Animation>().Play("Fadein");
                i++;
            }
            else if (Input.anyKeyDown && i == 5)
            {
                image[0].GetComponent<Animation>().Play("Fadeout");
                image[1].GetComponent<Animation>().Play("Fadeout");
                image[2].GetComponent<Animation>().Play("Fadeout");
                image[3].GetComponent<Animation>().Play("Fadeout");
                image[4].GetComponent<Animation>().Play("Fadeout");
            }
            else if (!image[4].GetComponent<Animation>().isPlaying && i == 5)
            {
                i = 0;
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "1")
        {
            image[8].GetComponent<Animation>().Play("Fadein");
            i++;
        }
        if (sceneName == "2")
        {
            image[3].GetComponent<Animation>().Play("Fadein");
            i++;
        }
        if (sceneName == "3")
        {
            image[6].GetComponent<Animation>().Play("Fadein");
            i++;
        }
        if (sceneName == "END1")
        {
            image[0].GetComponent<Animation>().Play("Fadein");
            i++;
        }
        if (sceneName == "END2")
        {
            image[0].GetComponent<Animation>().Play("Fadein");
            i++;
        }
        if (sceneName == "END3")
        {
            image[0].GetComponent<Animation>().Play("Fadein");
            i++;
        }
    }
}
