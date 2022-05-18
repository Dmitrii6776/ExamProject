using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerConfig playerConfig;
    [SerializeField] private InputAction movement;

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        // Movining forvard
        var zMove = playerConfig.speed * Time.deltaTime;
        //Movining LeftRight
        var leftRightMove = movement.ReadValue<Vector2>().x;
        var xOfSet = leftRightMove * playerConfig.leftRightSpeed * Time.deltaTime;
        transform.position += new Vector3(xOfSet, 0, zMove);
    }
}