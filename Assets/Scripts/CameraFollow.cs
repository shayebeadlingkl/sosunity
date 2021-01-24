using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform Target;
    private Vector3 Offset;
    private float SmoothingFactor;

    void FixedUpdate() {
        Vector3 targetPos = Target.position + Offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPos, SmoothingFactor *Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }

    public void SetTarget(Transform target) {
        Target = target;
    }

    public Transform GetTarget() {
        return Target;
    }

    public void SetSmoothingFactor(float sf) {
        SmoothingFactor = sf;
    }

    public float GetSmoothingFactor() {
        return SmoothingFactor;
    }
    public void SetOffset(Vector3 off) {
        Offset = off;
    }

    public Vector3 GetOffset() {
        return Offset;
    }
}
