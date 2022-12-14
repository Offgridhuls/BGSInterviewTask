using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public PlayerStats playerStats;

    public static PlayerBehaviour Instance { get; private set; }

    public Text moneyText;
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed = 1.0f;

    private bool facingRight, 
        isRunning;

    public SpriteRenderer torso, 
        hood, 
        pelvis;
    
    private Animator playerAnimator;
    public readonly int isMovingHash = Animator.StringToHash("isMoving");

    private Vector2 inputVector;
    private Rigidbody2D rb;

    private void Awake()
    {
        
        moneyText = GameObject.Find("MoneyCountText").GetComponent<Text>();
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputVector.x > 0 && facingRight)
        {
            FlipSprite();
        }
        if (inputVector.x < 0 && !facingRight)
        {
            FlipSprite();
        }

        if (inputVector.x > 0f ||
           inputVector.y > 0f ||
           inputVector.x < 0 ||
           inputVector.y < 0)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
        OnRun();

        moneyText.text = "$" + playerStats.moneyCount.ToString();
    }

    public void OnMovement(InputValue value)
    {
        inputVector = value.Get<Vector2>();
        rb.velocity = new Vector2(inputVector.x * moveSpeed, inputVector.y * moveSpeed);
    }
    private void OnRun()
    {
        playerAnimator.SetBool(isMovingHash, isRunning);
    }
    void FlipSprite()
    {
        
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;

    }

}
