using UnityEngine;

public class PlayerAttackDirection : ChangeAttackDirection
{
    private void Update()
    {
        _moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveChanging(_moveVector, _weaponPivot);
    }
    protected override void MoveChanging(Vector3 moveVector, Transform weaponPivot)
    {
        if (moveVector.x != 0 && moveVector.y == 0)
        {
            if (moveVector.x == 1)
            {
                ChangeAngle(180, weaponPivot);
            }
            else if (moveVector.x == -1)
            {
                ChangeAngle(0, weaponPivot);
            }
        }
        else if (moveVector.y != 0)
        {
            if (moveVector.y == 1)
            {
                ChangeAngle(90, weaponPivot);
            }

            if (moveVector.y == -1)
            {
                ChangeAngle(270, weaponPivot);
            }
        }
    }
}
