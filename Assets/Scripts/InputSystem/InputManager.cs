using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    
    private GameControls gameControls;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        gameControls = new GameControls();
        gameControls.Player.Enable();
    }

    public float GetMovementVector()
    {
        float inputVector = gameControls.Player.Walk.ReadValue<float>();
        
        return inputVector;
    }
    
}
