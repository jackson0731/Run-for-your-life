using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    AudioSource Song;
    public GameObject[] Itemfound;
    public int collectedItem;
    public GameObject enemy;
    public GameObject ItemText;
    public GameObject PickupText;
    public GameObject ReadMe;
    public GameObject PlayerWindow;
    public float i = 1;
    public int p = 0;
    public GameObject Image;
    public Texture2D page1;
    public Texture2D page2;
    public Texture2D page3;
    public Texture2D page4;
    public AudioSource pickItem;
    GameObject horse;
    public GameObject Final;
    public GameObject[] Story;
    public GameObject PlayWindow;

    void Start()
    {
        ItemText.SetActive(true);
        PickupText.SetActive(false);
        Song = GameObject.Find("Ava1").transform.GetChild(0).GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Itemfound[0].activeSelf == false)
        {
            Destroy(GameObject.FindGameObjectWithTag("air"));
        }
        if(collectedItem == 5)
        {
            PickupText.GetComponent<Text>().text = "回到重生點";
            PickupText.SetActive(true);
            Final.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider Item)
    {
        if (Item.gameObject.tag == "Item")
        {
            PickupText.GetComponent<Text>().text = "按E撿取物品" ;
            PickupText.SetActive(true);
        }
        if (Item.gameObject.tag == "book")
        {
            PickupText.GetComponent<Text>().text = "按E查看說明";
            PickupText.SetActive(true);
        }
        if (Item.gameObject.tag == "END")
        {
            SceneManager.LoadScene("END1");
        }
    }

    void OnTriggerStay(Collider Item)
    {
        if (Item.gameObject.tag == "Item")
        {
            if (Input.GetKey(KeyCode.E) && collectedItem <= 3)
            {
                Itemfound[collectedItem].SetActive(false);
                collectedItem++;
                ItemText.GetComponent<Text>().text = "" + collectedItem;
                Itemfound[collectedItem].SetActive(true);
                PickupText.SetActive(false);
                pickItem.Play();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                PlayWindow.gameObject.SetActive(false);
                Time.timeScale = 0;
                Song.Pause();
                Story[p].SetActive(true);
            }
            else if (Input.GetKey(KeyCode.E) && collectedItem == 4)
            {
                pickItem.Play();
                Itemfound[collectedItem].SetActive(false);
                collectedItem++;
                ItemText.GetComponent<Text>().text = "" + collectedItem;
                PickupText.SetActive(false);
            }
        }
        if (Item.gameObject.tag == "book")
        {
            if (Input.GetKey(KeyCode.E))
            {
                ReadMe.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                PlayerWindow.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider Item)
    {
        if (Item.gameObject.tag == "Item" || Item.gameObject.tag == "book")
        {
            PickupText.SetActive(false);
        }
    }

    public void ReadMeNextPage()
    {
        if (i == 1)
        {
            Image.GetComponent<RawImage>().texture = page2;
            i++;
        }else if (i == 2)
        {
            Image.GetComponent<RawImage>().texture = page3;
            i++;
        }else if (i == 3)
        {
            Image.GetComponent<RawImage>().texture = page4;
            i++;
        }else if (i == 4)
        {
            Image.GetComponent<RawImage>().texture = page1;
            ReadMe.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PlayerWindow.gameObject.SetActive(true);
            Time.timeScale = 1;
            i = 1;
        }
    }
    public void ReadMePrevPage()
    {
        if (i == 1)
        {
            Debug.Log("none");
        }
        else if (i == 2)
        {
            Image.GetComponent<RawImage>().texture = page1;
            i--;
        }
        else if (i == 3)
        {
            Image.GetComponent<RawImage>().texture = page2;
            i--;
        }
        else if (i == 4)
        {
            Image.GetComponent<RawImage>().texture = page3;
            i--;
        }
    }

    public void NextStroy()
    {
        if(p == 0)
        {
            enemy.SetActive(true);
            Story[p].SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PlayWindow.gameObject.SetActive(true);
            Time.timeScale = 1;
            Song.Play();
        }
        if(p <= 2)
        {
            Story[p].SetActive(false);
            p++;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PlayWindow.gameObject.SetActive(true);
            Time.timeScale = 1;
            Song.Play();
        }
        if(p == 3)
        {
            Story[p].SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PlayWindow.gameObject.SetActive(true);
            Time.timeScale = 1;
            Song.Play();
        }
    }
}
