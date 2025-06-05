using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void ChangeScene(int sceneIndex)
    {
        Debug.Log("Change Scene!");
        SceneManager.LoadScene(sceneIndex);
    }
}
