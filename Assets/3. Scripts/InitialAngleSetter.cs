using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialAngleSetter : MonoBehaviour
{
    float initX, initY, initZ;
    Transform tr;

    void Awake()
    {
        tr = GetComponent<Transform>();
        /*
        initX = Random.Range(0f, 0f);
        initY = Random.Range(0f, 360f);
        initZ = Random.Range(0f, 360f);
        tr.localRotation = Quaternion.Euler(initX, initY, initZ);
        */
        tr.localRotation = Random.rotationUniform;
    }

    public void PrintInitAngleLog()
    {
        Debug.Log($"({initX}, {initY}, {initZ})");
    }
}
