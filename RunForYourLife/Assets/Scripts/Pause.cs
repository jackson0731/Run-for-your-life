using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Pause : MonoBehaviour
{
    AudioSource Song;
    // Pause UI
    public GameObject PauseWindow;
    public GameObject valuewindow;
    public GameObject PlayWindow;
    public bool isPause;

    void Start()
    {
        isPause = false;
        Song = GameObject.Find("Ava1").transform.GetChild(0).GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            if (isPause == true)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                PlayWindow.gameObject.SetActive(false);
                PauseWindow.gameObject.SetActive(true);
                Time.timeScale = 0;
                Song.Pause();
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                PauseWindow.gameObject.SetActive(false);
                valuewindow.gameObject.SetActive(false);
                PlayWindow.gameObject.SetActive(true);
                Time.timeScale = 1;
                Song.Play();
            }
        }
    }

    public void Resume()
    {
        isPause = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        PauseWindow.gameObject.SetActive(false);
        PlayWindow.gameObject.SetActive(true);
        Time.timeScale = 1;
        Song.Play();
    }

    public void BackMainMenu()
    {
        Destroy(GameObject.Find("BGM"));
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}