using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    public float speed = 3f;
    public float jumpPower = 5f;

    private Rigidbody rigidbody;
    public GameObject wal1;
    public GameObject wal2;
    Vector3 movement;
    float horizontalMove;
    float verticalMove;
    bool isJumping;

    private bool IsJumping;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
            isJumping = true;
    }

    private void FixedUpdate()
    {
        Run();
        Jump();
        
    }

    void Run()
    {
        movement.Set(horizontalMove, 0, verticalMove);
        movement = movement.normalized * speed * Time.deltaTime;

        rigidbody.MovePosition(transform.position + movement);
    }
    void OnTriggerEnter(Collider other)
    {
        ItemController itemController = GameObject.FindObjectOfType<ItemController>();

        if (other.GetComponent<Collider>().tag == "Item1")
        {
            itemController.DestroyItem(other);
            wal1.transform.Translate(10, 0, 0);
        }

        if (other.GetComponent<Collider>().tag == "Item2")
        {
            itemController.DestroyItem(other);
            wal2.transform.Translate(0, 0, -20);
        }

        if (other.GetComponent<Collider>().tag == "Item3")
        {
            itemController.DestroyItem(other);
            wal1.transform.Translate(0, 1, 0);
        }

        if (other.GetComponent<Collider>().tag == "Item")
        {
            itemController.DestroyItem(other);
        }
    }

    void Jump()
    {
        if (!IsJumping)
            return;

        rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

        IsJumping = false;
        
    }



  


}
