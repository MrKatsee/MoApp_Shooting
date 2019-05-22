using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : Control
{
    Joystick joystick;

    public GameObject bullet;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    private void Update()
    {
        Move(new Vector3(joystick.Horizontal, joystick.Vertical, 0f));
    }

    public void Shoot()
    {
        GameObject bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);

        bulletInstance.GetComponent<Bullet>().Init_Bullet();
    }
}
