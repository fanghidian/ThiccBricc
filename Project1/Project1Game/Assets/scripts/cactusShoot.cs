using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusShoot : MonoBehaviour
{
    public Transform enemyFirePoint;
    public GameObject enemyBulletPrefab;
    public int waitEnemy = 1;
    private bool shoot;

    void Update()
    {
        if (!shoot)
            StartCoroutine("waitTime");
    }

    void wide()
    {
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, 135));
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, 180));
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, 225));
    }

    void narrow()
    {
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, 202));
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, Quaternion.Euler(0, 0, 152));
    }

    IEnumerator waitTime()
    {
        shoot = true;
        yield return new WaitForSeconds(waitEnemy);
        wide();
        yield return new WaitForSeconds(waitEnemy);
        narrow();
        shoot = false;
    }
}
