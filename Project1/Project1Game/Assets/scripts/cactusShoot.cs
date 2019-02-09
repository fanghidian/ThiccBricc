using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusShoot : MonoBehaviour
{
    public Transform enemyFirePoint;
    public GameObject enemyBulletPrefab;

    void Update()
    {
        wide();
        StartCoroutine(waitTime());
        narrow();
        StartCoroutine(waitTime());
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
        yield return new WaitForSeconds(2);
    }
}
