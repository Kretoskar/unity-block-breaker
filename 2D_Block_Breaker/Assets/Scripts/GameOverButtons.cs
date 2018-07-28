using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {

    private GameStatus mGameStatus;

	public void OnButtonTryAgainCLicked ()
    {
        mGameStatus = FindObjectOfType<GameStatus>();
        mGameStatus.ResetGame();
        int sceneToLoad = 1;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnButtonQuitClicked ()
    {
        Application.Quit();
    }
}
