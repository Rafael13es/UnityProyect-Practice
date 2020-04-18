using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float CameraMoveSpeed = 120.0f;
    public GameObject CameraFollowObj;
    Vector3 FollowPOS;
    public float clampAngle = 80.0f;
    public float inputSensitivity = 150.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;
    public float camDistanceXtoPlaer;
    public float camDistanceYtoPlaer;
    public float camDistanceYtoPlaer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputY;
    public float smoothX;
    public float smoothY;
    private float rotY = 0.0f;
    private float rotX = 0.0f;

    // Start is called before the first frame update
    void Start() {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotY = rot.x;
        Cursor.locState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
