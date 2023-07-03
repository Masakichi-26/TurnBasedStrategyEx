using Tactics.Grid.Topology;
using UnityEngine;

namespace Tactics.Grid.Map
{
    public class MapGrid : MonoBehaviour
    {
        public IGrid Grid { get; private set;}

        void Start()
        {
            Grid = new Grid2D(new SquareGrid(), 10, 10, 1);
        }
    }
}
