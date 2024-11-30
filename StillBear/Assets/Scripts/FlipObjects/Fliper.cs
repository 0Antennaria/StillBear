using UnityEngine;

public class Fliper : MonoBehaviour
{
    [SerializeField] protected bool FacingRight;
    protected Vector3 MoveVector;
    
    public void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
