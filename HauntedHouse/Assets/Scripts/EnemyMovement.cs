using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float triggerDistance;
    public float enemySpeed;

    private void Update()
    {
        float step = enemySpeed * Time.deltaTime;
        
        if (Vector2.Distance(gameObject.transform.position, playerTransform.position) < triggerDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, step);
        }
    }
}
