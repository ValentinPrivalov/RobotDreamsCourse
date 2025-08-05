using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputController _inputController;
    [SerializeField] private float moveSpeed = 7f;

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector2 inputVector = _inputController.GetMovementVectorNormalized();
        Vector3 moveDir = new(inputVector.x, 0f, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime;

        if (moveDir != Vector3.zero)
        {
            transform.position += moveDir * moveDistance;
        }
    }
}
