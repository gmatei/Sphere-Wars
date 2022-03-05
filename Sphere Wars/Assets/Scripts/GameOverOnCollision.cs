using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    public GameObject GameOverPanelUI;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            {
            FindObjectOfType<GameOver>().Pause();
            }
        
    }
}
