using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingDaggerProjectile : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] int damage = 5;

    public void SetDirection(float dir_x,float dir_y)
    {
        direction = new Vector3(dir_x, dir_y);

        if (dir_x < 0)
        {
            Vector3 Scale = transform.localScale;
            Scale.x = Scale.x * -1;
            Quaternion Rotation = transform.localRotation;
            Rotation.z = Rotation.z * -1;
            transform.localScale = Scale;
            transform.localRotation = Rotation;
        }
    }

    bool hitDetected = false;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        //프레임 사이 검사 건너뛰기
        if (Time.frameCount % 6 == 0)
        {
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.7f);
            foreach (Collider2D c in hit)
            {
                Enemy enemy = c.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                    hitDetected = true;
                    break;
                }
            }
            if (hitDetected == true)
            {
                Destroy(gameObject);

            }
        }
    }
}
