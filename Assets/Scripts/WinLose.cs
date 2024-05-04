using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Robot"))
        {
            if (this.CompareTag("False"))
            {
                Choose.instance.OpenLoseScene(Choose.loses.lose1);
            }
            else if (this.CompareTag("True"))
            {
                SceneTransition.instance.isEntered = false;
                Choose.instance.NextLevel();
                SceneTransition.instance.StartScreenTransition();
                Debug.Log("88");
            }
        }
    }
}
