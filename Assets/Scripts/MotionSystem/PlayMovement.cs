using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayMovement : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 720;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // animator = GetComponent<Animator>();
    }

    void Update()
    {
        EventSystem eventSystem = EventSystem.current;
        GameObject selectedGameObject = eventSystem.currentSelectedGameObject;
        // Debug.Log(selectedGameObject);
        if(selectedGameObject != null) return;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        horizontalInput *= -1;
        verticalInput *= -1;

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        
        if (movementDirection != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);            
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}
