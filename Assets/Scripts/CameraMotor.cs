using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAtMe;
    public float boundX = 0.15f, boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltaX = lookAtMe.position.x - transform.position.x;
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < lookAtMe.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else delta.x = deltaX + boundX;
        }
        float deltaY = lookAtMe.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAtMe.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else delta.y = deltaY + boundY;
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
