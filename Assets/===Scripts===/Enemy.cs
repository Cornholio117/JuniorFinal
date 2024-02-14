using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float startDely = 3f;
    private float startInterval = 2f;
    public GameObject enemyProjectile;
    public Transform firingPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FirePlayer", startDely, startInterval);
    }

    protected virtual void FirePlayer()
    {
        Instantiate(enemyProjectile, firingPosition.transform.position, enemyProjectile.transform.rotation);
    }
}
