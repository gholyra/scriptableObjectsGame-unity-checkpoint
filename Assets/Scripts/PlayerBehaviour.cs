using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public static PlayerBehaviour Instance;

    [SerializeField] private float velocity = 3f;
    [SerializeField] private int life = 3;
    
    private Vector2 moveDirection;
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleWalk();
    }

    private void HandleWalk()
    {
        float inputValue = InputManager.Instance.GetMovementVector();
        
        moveDirection.x = inputValue;
        rigidBody.velocity = new Vector2(moveDirection.x * velocity, rigidBody.velocity.y);
    }

    public void OnDamage(int damagePoints)
    {
        life -= damagePoints;
    }
    
}
