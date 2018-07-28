using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField]
    private int mBreakableBlocks;       //Serialized for debbuging

    [SerializeField]
    private GameObject mWinUI;
 
	public void CountBreakableBlocks()
    {
        mBreakableBlocks++;
    }

    public void BlockDestroyed()
    {
        mBreakableBlocks--;
        if(mBreakableBlocks <= 0)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene >= 5)
        {
            mWinUI.SetActive(true);
        }
        else
        {
            int sceneToLoad = currentScene + 1;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
