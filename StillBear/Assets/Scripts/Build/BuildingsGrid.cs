using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(10, 10);
    public Vector3 GridOffset = Vector3.zero;

    [SerializeField] private Honey _honey;
    
    private Building[,] _grid;
    private Building _flyingBuilding;
    private Camera _mainCamera;

    private void Awake()
    {
        _grid = new Building[GridSize.x, GridSize.y];

        _mainCamera = Camera.main;
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        if(_flyingBuilding == null)
        {
            Destroy(_flyingBuilding);
        }

        if (_honey.HoneyCount - buildingPrefab.BuildingCost >= 0)
        {
            _flyingBuilding = Instantiate(buildingPrefab);
        }
    }

    private void Update()
    {
        if (_flyingBuilding != null) 
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if (groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position) - GridOffset;

                int x = Mathf.RoundToInt(worldPosition.x);
                int y = Mathf.RoundToInt(worldPosition.z);

                _flyingBuilding.transform.position = new Vector3(x, 0, y) + GridOffset;

                if (Input.GetMouseButtonDown(0)) 
                {
                    _honey.ChangeHoney(-1 * _flyingBuilding.BuildingCost);
                    _flyingBuilding.GetComponent<Apairy>().enabled = true;
                    _flyingBuilding = null;
                }
            }
        }
    }


    private void OnDrawGizmosSelected()
    {
        for (int x = 0; x < GridSize.x; x++)
        {
            for (int y = 0; y < GridSize.y; y++)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawCube(transform.position + GridOffset + new Vector3(x, 0, y), new Vector3(1, .1f, 1));
            }
        }
    }
}
