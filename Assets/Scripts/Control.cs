using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float spd;

    public void Awake()
    {
        spd = 3f;
    }

    public virtual void Move(Vector3 _vec)
    {
        transform.Translate(_vec.normalized * spd * Time.deltaTime);
    }
}
