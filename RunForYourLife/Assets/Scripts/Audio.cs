using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "MainMenu" || sceneName == "Level" || sceneName == "1" || sceneName == "2" || sceneName == "3")
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume",volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetSoundEffectVolume(float volume)
    {
        audioMixer.SetFloat("SoundEffectVolume", volume);
    }

    public void SetVoiceVolume(float volume)
    {
        audioMixer.SetFloat("VoiceVolume", volume);
    }

    public void Reset()
    {
        Destroy(gameObject);
    }
}
