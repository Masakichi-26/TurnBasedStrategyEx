using TMPro;
using UnityEngine;

namespace Tactics.Grid
{
    public class GridDebugObject : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI debugText;

        private IGridPosition gridPosition { get; set; }

        public void SetGridObject(IGridPosition gridPosition)
        {
            this.gridPosition = gridPosition;
        }

        private void Update()
        {
            debugText.text = gridPosition.ToString();
        }
    }
}