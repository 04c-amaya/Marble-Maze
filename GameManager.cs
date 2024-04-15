using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    float rotationX;
    float rotationY;
    [SerializeField] float speed;
    public Rigidbody _rigidBody;
    public GameObject message;
    public AudioSource source;
    public AudioClip clip;
    public void OnTilt(InputAction.CallbackContext inputData)
    {
        //Debug.Log("Tilt:" + inputData);
        rotation = inputData.ReadValue<Vector3>();
        rotationX = rotation.x * speed;
        rotationY = rotation.y * speed;
        _rigidBody.AddForce(rotationX, 0, rotationY);
    }


   private void Awake()
    {
        message.SetActive(false);
        InputSystem.EnableDevice(Accelerometer.current);
    }
}
