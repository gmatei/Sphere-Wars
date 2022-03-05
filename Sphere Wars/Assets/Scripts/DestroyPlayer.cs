using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    public float WaitTime = 2.0f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            {
                PlayerLivesBlue.scoreValue --;
                Destroy(collision.gameObject);
                if (PlayerLivesBlue.scoreValue <= 0)
                    FindObjectOfType<GameOverYellow>().Pause();
                StartCoroutine("Reset", WaitTime);

            }

        if (collision.collider.tag == "Enemy")
            {
            PlayerLivesYellow.scoreValue--;
            Destroy(collision.gameObject);
            if (PlayerLivesYellow.scoreValue <= 0)
                FindObjectOfType<GameOverBlue>().Pause();
            StartCoroutine("Reset", WaitTime);

            }
    }
    IEnumerator Reset(float Count)
    {
        yield return new WaitForSeconds(Count);
        SceneManager.LoadScene("Multiplayer");                              
        yield return null;
    }
}
