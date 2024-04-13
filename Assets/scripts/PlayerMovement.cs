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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnMove(InputAction.CallbackContext ctx) => movementInp = ctx.ReadValue<Vector2>();

    // Update is called once per frame
    void Update()
    {
        if (movementInp.x > 0) {
            right = true;
        }
        else if (movementInp.x < 0)
        {
            right = false;
        }
        transform.Translate(new Vector3(movementInp.x,0,movementInp.y)*speed*Time.deltaTime);
        pivotAnim.SetBool("right", right);
        playerAnim.SetBool("Moving", movementInp.sqrMagnitude > 0);
    }


}
