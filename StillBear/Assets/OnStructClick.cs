using UnityEngine;

public class OnStructClick : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private Canvas BeeHouseMenu;
    private GameObject _beeHouse;
    void FixedUpdate()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    RaycastHit2D aHit = new RaycastHit2D();
        //    aHit = Physics2D.Raycast(_cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
        //    if(aHit.collider.gameObject.CompareTag("BeeHouse"))
        //    {
        //        BeeHouseMenu.gameObject.SetActive(true);
        //    }
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _beeHouse = transform.gameObject;
                BeeHouseMenu.gameObject.SetActive(true);
            };
        }
    }
}
