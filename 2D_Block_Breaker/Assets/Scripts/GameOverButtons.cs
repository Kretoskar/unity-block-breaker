using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {

	public void OnButtonTryAgainCLicked ()
    {
        int sceneToLoad = 1;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnButtonQuitClicked ()
    {
        Application.Quit();
    }
}
