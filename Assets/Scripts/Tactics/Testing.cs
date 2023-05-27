using Tactics.Grid;
using Tactics.Grid.Topology;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var grid = new Grid3D(new HexagonalGrid(), 10, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
