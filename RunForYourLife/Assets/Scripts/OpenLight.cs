using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLight : MonoBehaviour
{
    public GameObject flashlight;
    bool Openlight;
    public float use;
    public float power;
    public GameObject powerText;

    void Start()
    {
        power = 100;
        powerText.GetComponent<Text>().text = power + "%";
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && power != 0)
        {
            Openlight = !Openlight;
            flashlight.SetActive(Openlight);
        }else if (power == 0)
        {
            flashlight.SetActive(false);
        }

        if(flashlight.activeSelf == true)
        {
            use += Time.deltaTime;
        }
        if (use >= 5)
        {
            power--;
            powerText.GetComponent<Text>().text = power + "%";
            use = 0;
        }
    }
}
