using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform target;       // Player
    public float speed = 3f;        // Follow speed
    public float stopDistance = 2f; // How close it gets

    void Update()
    {
        if (target == null) return;

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > stopDistance)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Optional: rotate to face the player
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }
}