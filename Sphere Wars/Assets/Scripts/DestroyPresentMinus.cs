using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPresentMinus : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {    
        if (collision.collider.tag == "Player")       
            {
                PlayerLivesBlue.scoreValue--;
                Destroy(this.gameObject);
            if (PlayerLivesBlue.scoreValue <= 0)
                FindObjectOfType<GameOverYellow>().Pause();
        }

        if (collision.collider.tag == "Enemy")
            {
                PlayerLivesYellow.scoreValue--;
                Destroy(this.gameObject);

            if (PlayerLivesYellow.scoreValue <= 0)
                FindObjectOfType<GameOverBlue>().Pause();
        }      
    
    }
}
