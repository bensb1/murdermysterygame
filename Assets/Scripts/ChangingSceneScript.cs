using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingSceneScript : MonoBehaviour
{
 public void goBackToTitleSceneFromScrafGuyScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  -3);
    }
    public void goBackToTitleSceneFromRunnerGuyScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void goBackToTitleSceneFromBeardGuyScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
