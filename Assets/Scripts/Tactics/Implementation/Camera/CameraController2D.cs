using UnityEngine;
using VContainer;

namespace Tactics.Camera
{
    public class CameraController2D : MonoBehaviour
    {
        protected InputManager inputManager;

        [Inject]
        protected void Construct(InputManager inputManager)
        {
            this.inputManager = inputManager;
        }

        protected void Update()
        {
            HandleMovement();
            HandleRotation();
        }

        private void HandleMovement()
        {
            Vector2 inputMoveDir = inputManager.GetCameraMoveVector();

            Vector3 moveVector = transform.forward * inputMoveDir.y + transform.right * inputMoveDir.x;
            float moveSpeed = 10f;
            transform.position += moveVector * moveSpeed * Time.deltaTime;
        }

        private void HandleRotation()
        {
            Vector3 rotationVector = new Vector3(0, 0, 0);
            rotationVector.y = inputManager.GetCameraRotateAmount();

            float rotationSpeed = 100f;
            transform.eulerAngles += rotationVector * rotationSpeed * Time.deltaTime;
        }
    }
}
