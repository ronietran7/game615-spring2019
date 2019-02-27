using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
        transform.position = player.position + offset;
    }
}
