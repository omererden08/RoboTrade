using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public AudioSource soundPlayer;
    private float transitionTime = 1f;
    IEnumerator loadLevel;
    public void playThisSoundEffect()
    {
        soundPlayer.Play();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            soundPlayer.Play();
            loadLevel = LoadLevel(0);
            StartCoroutine(loadLevel);
            SceneTransition.instance.StartScreenTransition();
        }

    }
    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }
}
