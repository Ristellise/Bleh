using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public static class DeviceRotation
{
    private static bool gyroInitialized = false;

    public static bool HasGyroscope
    {
        get
        {
            return SystemInfo.supportsGyroscope;
        }
    }

    public static Quaternion Get()
    {
        if (!gyroInitialized)
        {
            InitGyro();
        }

        return HasGyroscope
            ? ReadGyroscopeRotation()
            : Quaternion.identity;
    }

    private static void InitGyro()
    {
        if (HasGyroscope)
        {
            Input.gyro.enabled = true;                // enable the gyroscope
            Input.gyro.updateInterval = 0.0167f;    // set the update interval to it's highest value (60 Hz)
        }
        gyroInitialized = true;
    }

    private static Quaternion ReadGyroscopeRotation()
    {
        return new Quaternion(0.5f, 0.5f, -0.5f, 0.5f) * Input.gyro.attitude * new Quaternion(0, 0, 1, 0);
    }
}

public class CarRotate : MonoBehaviour
{
    public float rot = 0.0F;

    float GetAngleByDeviceAxis(Vector3 axis)
    {
        Quaternion deviceRotation = DeviceRotation.Get();
        Quaternion eliminationOfOthers = Quaternion.Inverse(
            Quaternion.FromToRotation(axis, deviceRotation * axis)
        );
        Vector3 filteredEuler = (eliminationOfOthers * deviceRotation).eulerAngles;

        float result = filteredEuler.z;
        if (axis == Vector3.up)
        {
            result = filteredEuler.y;
        }
        if (axis == Vector3.right)
        {
            // incorporate different euler representations.
            result = (filteredEuler.y > 90 && filteredEuler.y < 270) ? 180 - filteredEuler.x : filteredEuler.x;
        }
        return result;
    }

    public void FixedUpdate()
    {
        if (!GlobalSwitchState.isPaused)
        {
            
            float roll = GetAngleByDeviceAxis(Vector3.forward);
            if (roll > 180.0f)
                roll = -(360 - roll);
            rot += roll/360.0f;

            if (rot > 0.0F || rot < 0.0F)
                GlobalSwitchState.rb.MoveRotation(GlobalSwitchState.rb.rotation * Quaternion.Euler(0, rot, 0));
            rot = (Mathf.Lerp(rot, 0.0F, Time.fixedDeltaTime) * GlobalSwitchState.rb.mass) / 1.25f;
            //Debug.Log(roll);
        }
    }
}
