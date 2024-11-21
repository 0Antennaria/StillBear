using UnityEngine;

public class ChangeAttackDirection : MonoBehaviour
{
    [SerializeField] private Transform _weaponPivot;
    private float _moveInputX;
    private float _moveInputY;

    private void Update()
    {
        _moveInputX = Input.GetAxisRaw("Horizontal");
        _moveInputY = Input.GetAxisRaw("Vertical");

        if (_moveInputX != 0 && _moveInputY == 0)
        {
            if(_moveInputX == 1)
            {
                ChangeAngle(180);
            }
            else if(_moveInputX == -1)
            {
                ChangeAngle(0);
            }
        }
        else if (_moveInputY != 0)
        {
            if (_moveInputY == 1)
            {
                ChangeAngle(90);
            }

            if (_moveInputY == -1)
            {
                ChangeAngle(270);
            }
        }
    }

    private void ChangeAngle(int angle)
    {
        Vector3 rotate = _weaponPivot.eulerAngles;
        rotate.y = angle;
        _weaponPivot.rotation = Quaternion.Euler(rotate);
    }
}
