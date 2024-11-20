using UnityEngine;

public class OnStructClick : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private Canvas BeeHouseMenu;
    // Update is called once per frame
    private void Start()
    {
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D aHit = new RaycastHit2D();
            aHit = Physics2D.Raycast(_cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if(aHit.collider.gameObject.CompareTag("BeeHouse"))
            {
                BeeHouseMenu.gameObject.SetActive(true);
            }
        }
    }
}
