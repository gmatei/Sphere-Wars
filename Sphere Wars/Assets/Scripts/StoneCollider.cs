using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCollider : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Player")
        {
            ScoreScript.scoreValue -= 25;
            FinalScoreScript.scoreValue -= 25;
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
