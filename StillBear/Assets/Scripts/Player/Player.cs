using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool IsInTrigger = false;
    [SerializeField] Canvas pasekaMenu;

    [SerializeField] private float speed;
    private StateMachine stateMachine;
    private Rigidbody rigidbody;
    private Vector3 movement = Vector3.zero;
    void Start(){
        stateMachine = new StateMachine(new IdleState(this));
        rigidbody = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "paseka")
        { return; }
        IsInTrigger = true;
        if(Input.GetKeyDown(KeyCode.E) && !pasekaMenu.gameObject.activeSelf)
        {
            Debug.Log("menu appears");
            pasekaMenu.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.E) && pasekaMenu.gameObject.activeSelf)
        {
            pasekaMenu.gameObject.SetActive(false);
            Debug.Log("menu disappears");
        }
    }
}
