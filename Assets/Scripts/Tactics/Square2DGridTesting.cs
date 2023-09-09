using Tactics.Grid;
using Tactics.Grid.Topology;
using UnityEngine;
using VContainer;

public class Square2DGridTesting : MonoBehaviour
{
    [SerializeField] private Transform gridDebugObjectPrefab;
    [SerializeField] private Transform gridDebugObjectParent;

    private IGrid grid;
    private MouseWorld mouseWorld;

    [Inject]
    private void Construct(MouseWorld mouseWorld)
    {
        this.mouseWorld = mouseWorld;
    }

    void Start()
    {
        grid = new Grid2D(new SquareGrid(), 10, 10, 1);
        ((Grid2D)grid).CreateDebugObjects(gridDebugObjectPrefab, gridDebugObjectParent);
        // Debug.Log(new GridCoordinates(1, 2, 3));
    }

    void Update()
    {
        // Debug.Log(grid.GetGridPosition(mouseWorld.GetPosition()));
    }
}
