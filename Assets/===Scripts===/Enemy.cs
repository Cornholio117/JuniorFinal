using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float m_startDely = 3f;
    public float startDely
    {
        get { return m_startDely; } 
        set { m_startDely = value; } 
    }
    private float m_startInterval = 2f;
    public float startInterval
    {
        get { return m_startInterval; } 
        set { m_startInterval = value; } 
    }

    [SerializeField] GameObject boomVFX;
    [SerializeField] AudioSource fireAudio;
    [SerializeField] AudioClip fireClip;

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
        fireAudio.PlayOneShot(fireClip, 1f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(boomVFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
