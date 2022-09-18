using UnityEngine;

public class InputControls : MonoBehaviour
{
    [SerializeField] bool FingerDown  = false;
    [SerializeField] float MoveDeltaX = 0.0f;
    private float LastPosX = 0.0f;
    
    public bool TouchDown   => FingerDown;
    public float Horizontal => MoveDeltaX;
    public static InputControls instance;

    private void Awake() {
        if (instance == null)
        instance = this;
    }

    private void Start() => Input.multiTouchEnabled = false;
    
    private void Update()
    { 
        GetInput();
    }//Update() end

    private void GetInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FingerDown = true;
            LastPosX   = Input.mousePosition.x;
        }//if end
        else if (Input.GetMouseButton(0))
        {
            MoveDeltaX = Input.mousePosition.x - LastPosX;
            LastPosX   = Input.mousePosition.x;
        }//else if end
        else if (Input.GetMouseButtonUp(0))
        {
            FingerDown = false;
            MoveDeltaX = 0.0f;
        }//else if end
    }//GetInput() end

}//class end