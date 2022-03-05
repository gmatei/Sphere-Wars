using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
            {
                ScoreScript.scoreValue += 5;
                FinalScoreScript.scoreValue += 5;
            }

        if (collision.collider.tag == strTag)
        {
            if (bDestroySelf)
                Destroy(this.gameObject);
            if (bDestroyOther)
                Destroy(collision.gameObject);
        }       
    }
}
