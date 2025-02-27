using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    public InputActionReference moveInputActionReference = null;
    private Vector2 m_inputVec2 = Vector2.zero;

    Rigidbody2D rb = null;

    [SerializeField] private float speed = 5.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }


    void Update()
    {
        if(Mathf.Abs(m_inputVec2.x)>0.1f || Mathf.Abs(m_inputVec2.y) > 0.1f)
        {
            rb.linearVelocity = m_inputVec2 * speed;
        }
    }

    private void OnEnable()
    {
        moveInputActionReference.action.performed += OnMove;
        moveInputActionReference.action.canceled += OnMove; // ˆÚ“®‚ðŽ~‚ß‚é‚Æ‚«‚à•K—v

        moveInputActionReference.action.Enable();

    }

    private void OnDisable()
    {
        moveInputActionReference.action.performed -= OnMove;
        moveInputActionReference.action.canceled -= OnMove;

        moveInputActionReference.action.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        m_inputVec2 = context.ReadValue<Vector2>();
        Debug.Log($"Move: {m_inputVec2}");
    }

}
