using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    private float input_X =0;
    private float input_Y =0;
    public Animator playerAnimator;
    private bool isWalking = false;
    [SerializeField]private float speed = 2.5f;


    private void Awake()
    {
        isWalking = false;

    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
            Move();
    }

    void Move()
    {
        input_X = Input.GetAxisRaw("Horizontal");
        input_Y = Input.GetAxisRaw("Vertical");
        isWalking = (input_X != 0 || input_Y != 0);

        if (isWalking)
        {
            Vector3 direcao = new Vector3(input_X, input_Y, 0).normalized;
            transform.position += direcao * speed * Time.fixedDeltaTime;
            playerAnimator.SetFloat("input_X", input_X);
            playerAnimator.SetFloat("input_Y", input_Y);
        }
            playerAnimator.SetBool("isWalking", isWalking);

    }
}
