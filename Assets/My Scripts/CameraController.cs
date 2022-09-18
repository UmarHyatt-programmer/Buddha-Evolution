using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float speedT;
    public Vector3 offSet;
    public float camlerpx;
    private void Start()
    {
        offSet = transform.position - target.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x * camlerpx, transform.position.y, target.position.z+offSet.z), speedT);
      
      //  transform.position = Vector3.Lerp(transform.position, target.position + offSet, speedT * Time.deltaTime);
    }



    // public Transform targetObject;

    // public Vector3 cameraOffset;
    // private void Start()
    // {
    //     cameraOffset = transform.position - targetObject.transform.position;
    // }
    // private void Update()
    // {
    //     MoveCam();
    // }
    // public void MoveCam()
    // {
    //     Vector3 newPosition = targetObject.transform.position + cameraOffset;
    //     transform.position = Vector3.Slerp(transform.position, new Vector3(newPosition.x, transform.position.y, newPosition.z), speedT);
    // }
}
