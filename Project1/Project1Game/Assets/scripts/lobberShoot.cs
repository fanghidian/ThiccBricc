using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobberShoot : MonoBehaviour
{
    public Transform enemyFirePoint;
    public GameObject enemyBulletPrefab;
    public int waitEnemy = 1;
    private bool shoot;
    public int arc = 135;

    void Update()
    {
        if (!shoot)
            StartCoroutine("waitTime");
    }

    void Lob()
    {
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, arc));
    }

    IEnumerator waitTime()
    {
        shoot = true;
        yield return new WaitForSeconds(waitEnemy);
        Lob();
        shoot = false;
    }

}
