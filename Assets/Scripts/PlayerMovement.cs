using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    Animator anim;
    public float playerMoveSpeed;
    ScoreBoard scoreboard;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        scoreboard = GameObject.Find("ScoreDisplay").GetComponent<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");

        var playerMovement = new Vector3(horizontalMovement, 0, verticalMovement);
        characterController.SimpleMove(playerMovement * Time.deltaTime * playerMoveSpeed);

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            Debug.Log("----------------------------------");
            scoreboard.Increment(10);
            Destroy(collision.gameObject);
        }
    }
}
