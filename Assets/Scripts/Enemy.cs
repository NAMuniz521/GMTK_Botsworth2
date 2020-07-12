using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("References")]
    public Transform shootPoint;
    public GameObject bullet;
    public GameObject player;
    public AudioSource enemyAudio;

    [Header("Properties")]
    public float fireInterval;
    public float timeToPatrol;
    public GameObject patrolPointA;
    public GameObject patrolPointB;

    GameObject currentPatrolPoint;

    Coroutine PatrolCoroutine;

    float tempTime;

    private void Start()
    {
        tempTime = Time.time + fireInterval;
        currentPatrolPoint = patrolPointA;
        enemyAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (PatrolCoroutine == null && currentPatrolPoint != null)
        {
            PatrolCoroutine = StartCoroutine(Patrol(transform.position, currentPatrolPoint.transform.position, timeToPatrol));
        }

        transform.right = -1 * (player.transform.position - transform.position);

        if (tempTime < Time.time)
        {
            Shoot();
            tempTime = Time.time + fireInterval;
        }
    }

    IEnumerator Patrol(Vector3 startPos, Vector3 endPos, float overTime)
    {
        float startTime = Time.time;
        while (Time.time < startTime + overTime)
        {
            transform.position = Vector3.Lerp(startPos, endPos, (Time.time - startTime) / overTime);
            yield return null;
        }
        transform.position = endPos;

        if (currentPatrolPoint == patrolPointA)
        {
            currentPatrolPoint = patrolPointB;
        }
        else
        {
            currentPatrolPoint = patrolPointA;
        }
        PatrolCoroutine = null;
    }

    public void Shoot()
    {
        //Debug.Log("pew pew");
        //RaycastHit2D hitInfo = Physics2D.Raycast(shootPoint.position, -1 * shootPoint.right);
        int sound;
        sound = Random.Range(1, 5);
        switch (sound)
        {
            case 1: enemyAudio.clip = AudioManager.singleton.shot1;
                break;
            case 2: enemyAudio.clip = AudioManager.singleton.shot2;
                break;
            case 3: enemyAudio.clip = AudioManager.singleton.shot3;
                break;
            default: enemyAudio.clip = AudioManager.singleton.shot4;
                break;
        }
            
        GameObject projectile = Instantiate(bullet);
        projectile.GetComponent<Projectile>().shootPoint = shootPoint;
        projectile.transform.localPosition = shootPoint.transform.position;
        enemyAudio.Play();


        //if (hitInfo)
        //{
        //    //Debug.Log(hitInfo.transform.name);
        //}
    }

    public void Die()
    {
        enemyAudio.clip = AudioManager.singleton.pop;
        enemyAudio.Play();
        Destroy(gameObject);
    }
}
