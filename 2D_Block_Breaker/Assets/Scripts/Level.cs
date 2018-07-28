using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField]
    private int mBreakableBlocks;       //Serialized for debbuging

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
        int sceneToLoad = currentScene + 1;
        SceneManager.LoadScene(sceneToLoad);
    }
}
