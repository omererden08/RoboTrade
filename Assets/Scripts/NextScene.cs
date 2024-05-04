using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    IEnumerator loadLevel;
    private float transitionTime = 1f;


    private void Awake()
    {
        loadLevel = LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && TextWriter.Instance.endText == true)
        {
            SceneTransition.instance.isEntered = false;
            Choose.instance.NextLevel();
            SceneTransition.instance.StartScreenTransition();
        }
    }

    public void LoadLevel()
    {
        loadLevel = LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(loadLevel);
    }

    public IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
