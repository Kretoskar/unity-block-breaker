using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour {

    [SerializeField]
    GameObject gameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverUI.SetActive(true);
    }
}
