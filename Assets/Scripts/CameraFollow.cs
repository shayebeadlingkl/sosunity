using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float SmoothingFactor;

    void FixedUpdate()
    {
        Vector3 targetPos = Target.position + Offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPos, SmoothingFactor *Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
