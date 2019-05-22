using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : Control
{
    Vector3 moveVec = Vector3.zero;

    public void Init_Enemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-3f, 3f), 8f, 0f);

        transform.position = spawnPos;

        moveVec = Vector3.down;

        Invoke("DestroyCall", 5f);
    }

    private void Update()
    {
        Move(moveVec);
    }

    public void DestroyCall()
    {
        Destroy(gameObject);
    }
}
