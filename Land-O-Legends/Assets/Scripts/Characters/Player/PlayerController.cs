using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Movement Variables
    [Header("Movement Variables")]
    public Vector2 MovementVector;
    public float MoveSpeed;
    [SerializeField]
    float _walkSpeed = 100f;
    [SerializeField]
    float _sprintSpeed = 225f;
    public bool IsSprinting;
    #endregion

    #region Components
    Rigidbody2D _rb;
    #endregion

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        IsSprinting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSprinting)
        {
            MoveSpeed = _sprintSpeed;
        }
        else
        {
            MoveSpeed = _walkSpeed;
        }
    }

    void FixedUpdate()
    {
        _rb.velocity = MovementVector * MoveSpeed * Time.fixedDeltaTime;
    }

    public void HandleMoveInput(Vector2 input)
    {
        MovementVector = input;
    }

    public void HandleSprintInput()
    {
        IsSprinting = !IsSprinting;
    }
}
