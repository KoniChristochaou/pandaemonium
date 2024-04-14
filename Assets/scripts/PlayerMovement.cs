using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    private Vector2 movementInp;
    [SerializeField]
    float speed;
    public Animator pivotAnim;
    public Animator playerAnim;
    public bool right;
    private Rigidbody rb;
    public static PlayerMovement pm;
    // Start is called before the first frame update
    void Awake()
    {
        pm = this;
        rb = GetComponent<Rigidbody>();
    }
    public void OnMove(InputAction.CallbackContext ctx) => movementInp = ctx.ReadValue<Vector2>();

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementInp.x > 0) {
            right = true;
        }
        else if (movementInp.x < 0)
        {
            right = false;
        }
        rb.velocity = new Vector3(movementInp.x,0,movementInp.y).normalized*speed;
        pivotAnim.SetBool("right", right);
        playerAnim.SetBool("Moving", movementInp.sqrMagnitude > 0);
    }



}
