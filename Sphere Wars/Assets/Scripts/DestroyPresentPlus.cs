using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPresentPlus : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerLivesBlue.scoreValue++;
            Destroy(this.gameObject);
        }

        if (collision.collider.tag == "Enemy")
        {
            PlayerLivesYellow.scoreValue++;
            Destroy(this.gameObject);
        }

    }
}
