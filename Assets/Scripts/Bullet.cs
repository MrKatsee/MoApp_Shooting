using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 moveVec;

    float spd = 5f;

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Enemy")
        {
            PlayManager.Instance.Score += 10f;

            c.gameObject.GetComponent<EnemyControl>().DestroyCall();
            DestroyCall();
        }
    }

    public void Init_Bullet()
    {
        moveVec = Vector3.up;
        spd = 5f;
    }

    private void Update()
    {
        Move(moveVec);
    }

    public virtual void Move(Vector3 _vec)
    {
        transform.Translate(_vec.normalized * spd * Time.deltaTime);
    }

    void DestroyCall()
    {
        Destroy(gameObject);
    }
}
