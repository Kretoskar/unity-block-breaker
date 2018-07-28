using UnityEngine;

public class LoseTrigger : MonoBehaviour {

    [SerializeField]
    private GameObject mGameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mGameOverUI.SetActive(true);
    }
}
