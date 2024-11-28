using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Camera _followingCamera;
    [SerializeField] private Transform _followingTarget;

    [SerializeField] private Vector2 _offset;

    private Transform CameraPosition => _followingCamera.transform;

    private void LateUpdate()
    {
        CameraPosition.position = _followingTarget.position + new Vector3(-_offset.x, CameraPosition.position.y, -_offset.y);
    }
}
