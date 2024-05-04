using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float transitionTime = 1f;
    IEnumerator loadLevel;
    public AudioSource soundPlayer;

    private void Start()
    {
        Cursor.visible = true;
    }
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }


    public void StartGame()
    {
        soundPlayer.Play();
        loadLevel = LoadLevel(2);
        StartCoroutine(loadLevel);
        SceneTransition.instance.StartScreenTransition();
    }
    public void ExitGame()
    {
        soundPlayer.Play();
        Application.Quit();
        SceneTransition.instance.StartScreenTransition();
    }
    public void RestartGame()
    {
        soundPlayer.Play();
        loadLevel = LoadLevel(0);
        StartCoroutine(loadLevel);
        SceneTransition.instance.StartScreenTransition();
    }
    public void Controls()
    {
        soundPlayer.Play();
        loadLevel = LoadLevel(1);
        StartCoroutine(loadLevel);
        SceneTransition.instance.StartScreenTransition();
    }
    public void BackToStart()
    {
        soundPlayer.Play();
        loadLevel = LoadLevel(0);
        StartCoroutine(loadLevel);
        SceneTransition.instance.StartScreenTransition();
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
        
    }
    public void playThisSoundEffect()
    {
        soundPlayer.Play();
    }
}











