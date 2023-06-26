using Tactics.Grid;
using Tactics.Grid.Topology;
using UnityEngine;
using VContainer;

public class HexagonalGridTesting : MonoBehaviour
{
    private IGrid grid;
    private MouseWorld mouseWorld;

    [Inject]
    private void Construct(MouseWorld mouseWorld)
    {
        this.mouseWorld = mouseWorld;
    }

    void Start()
    {
        grid = new Grid3D(new HexagonalGrid(), 10, 1, 10);
        Debug.Log(new GridCoordinates(1, 2, 3));
    }

    void Update()
    {
        Debug.Log(grid.GetGridPosition(mouseWorld.GetPosition()));
    }
}
