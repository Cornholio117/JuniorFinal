using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrange : Enemy
{

    private void Start()
    {
        startDely -= 1;
        startInterval -= 1.5f;
        InvokeRepeating("FirePlayer", startDely, startInterval);
    }
    protected override void FirePlayer()
    {
        Instantiate(enemyProjectile, firingPosition.transform.position, enemyProjectile.transform.rotation);
    }
}
