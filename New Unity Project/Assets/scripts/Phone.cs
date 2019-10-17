using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    Quaternion phoneRot;
    Vector3 phoneVec;
    private bool gyroEnabled;
    private Gyroscope gyro;

    float y;
    float x;
    float z;

    public float smoothTime = 0.03f;

    void Start()
    {
        gyroEnabled = EnabledGyro();
    }

    private bool EnabledGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        return false;
    }

    void Update()
    {
        if (gyroEnabled)
        {
            Gyro();
            phoneRot = Quaternion.Euler(x, y, -z);
            transform.rotation = Quaternion.Slerp(transform.rotation, phoneRot, smoothTime);
            smoothTime = smoothTime + Time.deltaTime;
        }
    }

    public void Gyro()
    {
        x = gyro.attitude.eulerAngles.y;
        y = gyro.attitude.eulerAngles.z;
        z = gyro.attitude.eulerAngles.x;

    }
}
