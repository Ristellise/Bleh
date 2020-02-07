using UnityEngine;
using System.Collections;

public class SphereFollower : MonoBehaviour
{
    Transform leader = null;
    public float sharpness = 0.1f;
    Vector3 offSet;
    // Use this for initialization

    public void setLeader(Transform t)
    {
        leader = t;
        offSet = transform.position - t.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (leader != null)
        {
            Vector3 targetPosition = leader.position + offSet;
            targetPosition.y = transform.position.y;
            transform.position += (targetPosition - transform.position) * sharpness;
        }
    }
}
