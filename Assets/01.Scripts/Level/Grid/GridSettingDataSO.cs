using UnityEngine;

[CreateAssetMenu(menuName = "SO/Grid Setting Data", fileName = "Grid Setting Data")]
public class GridSettingDataSO : ScriptableObject
{
    public Vector2Int gridSize;
    public Vector2Int startSize; // ex) 3 x 3
    // 센터 오브젝트
}
