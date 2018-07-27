using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

	public void OnButtonPlayClicked ()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneToLoad = currentSceneIndex + 1;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnButtonQuitClicked()
    {
        Application.Quit();
    }
}
