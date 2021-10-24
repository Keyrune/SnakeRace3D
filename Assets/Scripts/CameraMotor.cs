using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    [SerializeField]
    private Transform followTarget;
    
    [SerializeField]
    private float dumping = 100f;
    private Vector3 offset;
    private float horOffset;

    private void Start() 
    {
        offset = transform.position - followTarget.position;
        offset.x = 0f;
    }

    private void LateUpdate()
    {

        Vector3 desiredPosition = followTarget.position + offset;
        desiredPosition.x = 0f;
        desiredPosition = Vector3.Lerp(transform.position, desiredPosition, dumping * Time.deltaTime);
        transform.position = desiredPosition;

    }

}
