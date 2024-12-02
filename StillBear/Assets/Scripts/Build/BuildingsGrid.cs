using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(10, 10);
    public Vector3 GridOffset = Vector3.zero;

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

        _flyingBuilding = Instantiate(buildingPrefab);
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

                bool avaliable = true;

                if(x < 0 || x > GridSize.x - _flyingBuilding.Size.x)
                    avaliable = false;

                if (y < 0 || y > GridSize.y - _flyingBuilding.Size.y)
                    avaliable = false;

                if (avaliable && IsPlaceTaken(x, y)) 
                    avaliable = false;

                _flyingBuilding.transform.position = new Vector3(x, 0, y) + GridOffset;

                if (avaliable && Input.GetMouseButtonDown(0)) 
                {
                    PlaceFlyingBuilding(x, y);
                }
            }
        }
    }

    private bool IsPlaceTaken(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                if(_grid[placeX + x, placeY + y] != null)
                    return true;
            }
        }
        return false;
    }

    private void PlaceFlyingBuilding(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                _grid[placeX + x, placeY + y] = _flyingBuilding;
            }
        }

        _flyingBuilding = null;
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
