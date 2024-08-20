using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFaceCamera : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCamera.transform);
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + 180f, 0f);
    }
}
