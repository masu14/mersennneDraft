using UnityEngine;

public class ThroughFloorController : MonoBehaviour
{
    PlatformEffector2D platformEffector2D;
    
    void Start()
    {
        platformEffector2D = GetComponent<PlatformEffector2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            platformEffector2D.rotationalOffset = 180f;
        }
        else if (Input.GetButtonDown("Jump"))//InputEventProviderで処理すべきなので後ほど修正
        {
            platformEffector2D.rotationalOffset = 0f;
        }
    }
}
