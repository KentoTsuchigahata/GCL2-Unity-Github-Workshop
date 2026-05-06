using System;
using UnityEngine;
using UnityEngine.UIElements;

public class FastEnemy : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    public float moveSpeed = 2f;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                rightPoint.position,
                moveSpeed * Time.deltaTime
            );

            if (Vector2.Distance(transform.position, rightPoint.position) < 0.05f)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                leftPoint.position,
                moveSpeed * Time.deltaTime
            );

            if (Vector2.Distance(transform.position, leftPoint.position) < 0.05f)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}