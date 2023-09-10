using UnityEngine;
using Cinemachine;

namespace Tactics.Camera
{
    public class CameraController3D : CameraController2D
    {
        private const float MIN_FOLLOW_Y_OFFSET = 2f;
        private const float MAX_FOLLOW_Y_OFFSET = 12f;

        [SerializeField] CinemachineVirtualCamera virtualCamera;

        private CinemachineTransposer cinemachineTransposer;
        private Vector3 targetFollowOffset;
        
        private void Start()
        {
            cinemachineTransposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
            targetFollowOffset = cinemachineTransposer.m_FollowOffset;
        }

        protected void Update()
        {
            base.Update();
            HandleZoom();
        }

        private void HandleZoom()
        {
            float zoomIncreaseAmount = 1f;
            targetFollowOffset.y += inputManager.GetCameraZoomAmount() * zoomIncreaseAmount;
            targetFollowOffset.y = Mathf.Clamp(targetFollowOffset.y, MIN_FOLLOW_Y_OFFSET, MAX_FOLLOW_Y_OFFSET);
            float zoomSpeed = 6f;
            cinemachineTransposer.m_FollowOffset = Vector3.Lerp(cinemachineTransposer.m_FollowOffset, targetFollowOffset, Time.deltaTime * zoomSpeed);
        }
    }
}
