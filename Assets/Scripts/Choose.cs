using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choose : MonoBehaviour
{
    protected float transitionTime = 1.5f;
    protected IEnumerator sceneload;

    public loses targetlose;
    public enum loses
    {
        lose1, lose2, lose3, lose4, lose5, lose6
    }


    public void OpenLoseScene(loses targetlose)
    {
        switch (this.targetlose)
        {
            case loses.lose1:
                {
                    LoseSceneByIndex(20);
                    break;
                }
            case loses.lose2:
                {
                    LoseSceneByIndex(21);
                    break;
                }
            case loses.lose3:
                {
                    LoseSceneByIndex(22);
                    break;
                }
            case loses.lose4:
                {
                    LoseSceneByIndex(23);
                    break;
                }
            case loses.lose5:
                {
                    LoseSceneByIndex(24);
                    break;
                }
            case loses.lose6:
                {
                    LoseSceneByIndex(25);
                    break;
                }
            default:
                break;
        }
    }


    public static Choose instance;

    private void Awake()
    {
        instance = this;
        Debug.Log(instance.gameObject.name);
    }
    private void OnDisable()
    {
        Destroy(instance);
    }

    protected IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    public void NextLevel()
    {
        sceneload = LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(sceneload);
        SceneTransition.instance.StartScreenTransition();
    }
    
    public void LoseSceneByIndex(int levelIndex)
    {
        sceneload = LoadLevel(levelIndex);
        StartCoroutine(sceneload);
        SceneTransition.instance.StartScreenTransition();
    }
}

