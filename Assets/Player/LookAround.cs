using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    [SerializeField] private Vector2 sens;
    private Vector2 rotation, mouse;
    private Transform orientation;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        orientation = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mouse.x = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens.x;
        mouse.y = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sens.y;

        rotation.y += mouse.x;
        rotation.x -= mouse.y;
        rotation.x = Mathf.Clamp(rotation.x, -90f,90f);

        transform.rotation = Quaternion.Euler(rotation);
    }
}
