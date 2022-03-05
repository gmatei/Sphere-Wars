using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollider : MonoBehaviour
{   [SerializeField]
    string strTag;
    [SerializeField]
    bool bDestroySelf = false;
    [SerializeField]
    bool bDestroyOther = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            {ScoreScript.scoreValue += 10;
            FinalScoreScript.scoreValue += 10;
            }
        if (collision.collider.tag == strTag)
            {if (bDestroySelf)
                Destroy(this.gameObject);
            if (bDestroyOther)
                Destroy(collision.gameObject);
            }
    }
}
