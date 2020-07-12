using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("References")]
    public Transform shootPoint;
    public GameObject bullet;

    [Header("Properties")]
    public float fireInterval;
    public float speed;
    public Vector2 patrolPointA;
    public Vector2 patrolPointB;

    float tempTime;

    private void Start()
    {
        tempTime = Time.time + fireInterval;
    }

    private void Update()
    {
        // TODO: make it move on a path

        if (tempTime < Time.time)
        {
            Shoot();
            tempTime = Time.time + fireInterval;
        }
    }

    public void Shoot()
    {
        Debug.Log("pew pew");
        //RaycastHit2D hitInfo = Physics2D.Raycast(shootPoint.position, -1 * shootPoint.right);

        GameObject projectile = Instantiate(bullet);
        projectile.transform.localPosition = shootPoint.transform.position;

        //if (hitInfo)
        //{
        //    //Debug.Log(hitInfo.transform.name);
        //}
    }

    public void Die()
    {
        // TODO: do any death effects or sound effects here
        Destroy(gameObject);
    }
}
