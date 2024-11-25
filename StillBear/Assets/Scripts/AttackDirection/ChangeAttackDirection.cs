using UnityEngine;

public abstract class ChangeAttackDirection : MonoBehaviour
{
    [SerializeField] protected Transform _weaponPivot;
    protected Vector3 _moveVector;
    protected abstract void MoveChanging(Vector3 moveVector, Transform weaponPivot);

    protected void ChangeAngle(int angle, Transform weaponPivot)
    {
        Vector3 rotate = weaponPivot.eulerAngles;
        rotate.y = angle;
        weaponPivot.rotation = Quaternion.Euler(rotate);
    }
}