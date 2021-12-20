
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D playerBody; //refers to the Rigid body of the Player
    public float jumpStrength = 400f;
    public float moveSpeed = 10f;
    public Animator animator;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;





    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); //This function will return the horizontal inputs, "A" and "D", to the X-axis of the Vector2 movement
        movement.y = Input.GetAxisRaw("Vertical"); //This function will return the Vertical inputs, "W" and "S", to the Y-axis of the Vector2 movement

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

     void FixedUpdate()
    {
        playerBody.MovePosition(playerBody.position + movement * moveSpeed * Time.fixedDeltaTime); // This function will translate the Vector2 movement into the player's movement within the scene

        Vector2 lookDir = mousePos - playerBody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        playerBody.rotation = angle;



        //animator.SetFloat("horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
