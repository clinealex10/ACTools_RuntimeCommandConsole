using UnityEngine;
using UnityEngine.UI;

// Based on this Game Dev Guide video: https://www.youtube.com/watch?v=CGsEJToeXmA
public class FlexibleGridLayout : LayoutGroup
{
    [SerializeField] private FitType fitType = FitType.Uniform;
    [SerializeField] private bool fitWidth = false;
    [SerializeField] private bool fitHeight = false;

    [Space]

    [SerializeField] private int rows = 0;
    [SerializeField] private int columns = 0;
    [SerializeField] private Vector2 cellSize = Vector2.zero;
    [SerializeField] private Vector2 spacing = Vector2.zero;

    public override void CalculateLayoutInputHorizontal()
    {
        base.CalculateLayoutInputHorizontal();

        if (fitType == FitType.Uniform || fitType == FitType.Width || fitType == FitType.Height)
        {
            fitWidth = true;
            fitHeight = true;

            float squareRoot = Mathf.Sqrt(transform.childCount);
            rows = Mathf.CeilToInt(squareRoot);
            columns = Mathf.CeilToInt(squareRoot);
        }

        if (fitType == FitType.Width || fitType == FitType.FixedColumns)
            rows = Mathf.CeilToInt(transform.childCount / (float)columns);
        if (fitType == FitType.Height || fitType == FitType.FixedRows)
            columns = Mathf.CeilToInt(transform.childCount / (float)rows);

        float parentWidth = rectTransform.rect.width;
        float parentHeight = rectTransform.rect.height;

        float cellWidth = (parentWidth / columns) - ((spacing.x /  columns) * 2) - (padding.left / (float) columns) - (padding.right / (float) columns);
        float cellHeight = (parentHeight / rows) - ((spacing.y / rows) * 2) - (padding.top / (float) rows) - (padding.bottom / (float) rows);

        cellSize.x = fitWidth ? cellWidth : cellSize.x;
        cellSize.y = fitHeight ? cellHeight : cellSize.y;

        int rowCount = 0;
        int columnCount = 0;

        for (int index = 0; index < rectChildren.Count; ++index)
        {
            rowCount = index / columns;
            columnCount = index % columns;

            RectTransform rectChild = rectChildren[index];

            float xPosition = (cellSize.x * columnCount) + (spacing.x * columnCount) + padding.left;
            float yPosition = (cellSize.y * rowCount) + (spacing.y * rowCount) + padding.top;

            SetChildAlongAxis(rectChild, 0, xPosition, cellSize.x);
            SetChildAlongAxis(rectChild, 1, yPosition, cellSize.y);
        }
    }

    public override void CalculateLayoutInputVertical()
    {

    }

    public override void SetLayoutHorizontal()
    {

    }

    public override void SetLayoutVertical()
    {

    }

    public enum FitType
    {
        Uniform,
        Width,
        Height,
        FixedRows,
        FixedColumns,
    }
}