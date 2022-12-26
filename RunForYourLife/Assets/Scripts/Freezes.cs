using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Freezes : MonoBehaviour
{
    public GameObject Light;
    public GameObject Player;
    public GameObject LightImage;
    bool Openlight;
    public bool bIsOnTheMove = false;
    public float i;
    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        i = 10;
        Light.SetActive(false);
        LightImage.SetActive(false);
    }

    void Update()
    {
        if(i <= 0)
        {
            Openlight = true;
            Light.SetActive(Openlight);
            i = 15;
            StartCoroutine(DontMove());
        }
        if(i <= 3 && Openlight == false)
        {
            StartCoroutine(LightImage1());
        }
        if(Openlight == true)
        {
            LightImage.SetActive(false);
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                bIsOnTheMove = true;
            }
            else
            {
                bIsOnTheMove = false;
            }
            StartCoroutine(Death());
        }
        i -= Time.deltaTime;
    }

    IEnumerator LightImage1()
    {
        LightImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        LightImage.SetActive(false);
    }

    IEnumerator DontMove()
    {
        yield return new WaitForSeconds(5f);
        Openlight = false;
        Light.SetActive(Openlight);
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(0.7f);
        if (Openlight == true && bIsOnTheMove == true)
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
