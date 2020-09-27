using UnityEngine;

public static class DebugExtensions
{
    #region DrawShapes
    /// <summary> Draws a 4-sided 2D shape in 3D space. </summary>
    /// <param name="leftBottom"> Bottom left corner of the shape. </param>
    /// <param name="rightBottom"> Bottom right corner of the shape. </param>
    /// <param name="leftTop"> Top left corner of the shape. </param>
    /// <param name="rightTop"> Top right corner of the shape. </param>
    /// <param name="color"> Color of the shape. </param>
    /// <param name="duration"> How long for the shape be visible for? </param>
    /// <param name="depthTest"> Should the shape be obscured by objects closer to the camera? </param>
    public static void DrawQuadrilateral(Vector3 leftBottom, Vector3 rightBottom, Vector3 leftTop, Vector3 rightTop, Color color, float duration, bool depthTest)
    {
        Debug.DrawLine(leftBottom, rightBottom, color, duration, depthTest);
        Debug.DrawLine(rightBottom, rightTop, color, duration, depthTest);
        Debug.DrawLine(rightTop, leftTop, color, duration, depthTest);
        Debug.DrawLine(leftTop, leftBottom, color, duration, depthTest);
    }

    /// <summary> Draws a rectangle. Only works in 2D space along the z axis. </summary>
    /// <param name="leftBottom"> Bottom left corner of the shape. </param>
    /// <param name="rightTop"> Top right corner of the shape. </param>
    /// <param name="z"> Z value for the rectangle. </param>
    /// <param name="color"> Color of the shape. </param>
    /// <param name="duration"> How long for the shape be visible for? </param>
    /// <param name="depthTest"> Should the shape be obscured by objects closer to the camera? </param>
    public static void DrawRect(Vector3 leftBottom, Vector3 rightTop, float z, Color color, float duration, bool depthTest)
    {
        Vector3 rightBottom = new Vector3(rightTop.x, leftBottom.y, z);
        Vector3 leftTop = new Vector3(leftBottom.x, rightTop.y, z);

        Debug.DrawLine(leftBottom, rightBottom, color, duration, depthTest);
        Debug.DrawLine(rightBottom, rightTop, color, duration, depthTest);
        Debug.DrawLine(rightTop, leftTop, color, duration, depthTest);
        Debug.DrawLine(leftTop, leftBottom, color, duration, depthTest);
    }

    /// <summary> Draws a rectangular prism. </summary>
    /// <param name="leftBottomBack"> Bottom left back corner of the shape. </param>
    /// <param name="rightTopFront"> Top right front corner of the shape. </param>
    /// <param name="color"> Color of the shape. </param>
    /// <param name="duration"> How long for the shape be visible for? </param>
    /// <param name="depthTest"> Should the shape be obscured by objects closer to the camera? </param>
    public static void DrawRectPrism(Vector3 leftBottomBack, Vector3 rightTopFront, Color color, float duration, bool depthTest)
    {
        Vector3 leftBottomFront = new Vector3(leftBottomBack.x, leftBottomBack.y, rightTopFront.z);
        Vector3 rightBottomBack = new Vector3(rightTopFront.x, leftBottomBack.y, leftBottomBack.z);
        Vector3 rightBottomFront = new Vector3(rightTopFront.x, leftBottomBack.y, rightTopFront.z);

        Vector3 rightTopBack = new Vector3(rightTopFront.x, rightTopFront.y, leftBottomBack.z);
        Vector3 leftTopFront = new Vector3(leftBottomBack.x, rightTopFront.y, rightTopFront.z);
        Vector3 leftTopBack = new Vector3(leftBottomBack.x, rightTopFront.y, leftBottomBack.z);

        DrawQuadrilateral(leftBottomFront, rightBottomFront, leftTopFront, rightTopFront, color, duration, depthTest);  // Front Face
        DrawQuadrilateral(rightBottomFront, rightBottomBack, rightTopFront, rightTopBack, color, duration, depthTest);  // Right Face
        DrawQuadrilateral(rightBottomBack, leftBottomBack, rightTopBack, leftTopBack, color, duration, depthTest);  // Back Face
        DrawQuadrilateral(leftBottomBack, leftBottomFront, leftTopBack, leftTopFront, color, duration, depthTest);  // Left Face
        DrawQuadrilateral(leftTopFront, rightTopFront, leftTopBack, rightTopBack, color, duration, depthTest);              // Top Face
        DrawQuadrilateral(leftBottomBack, rightBottomBack, leftBottomFront, rightBottomFront, color, duration, depthTest);  // Bottom Face
    }

    /// <summary> Draws a cube. </summary>
    /// <param name="center"> Center point of the shape. </param>
    /// <param name="length"> Length of any edge of the shape. </param>
    /// <param name="color"> Color of the shape. </param>
    /// <param name="duration"> How long for the shape be visible for? </param>
    /// <param name="depthTest"> Should the shape be obscured by objects closer to the camera? </param>
    public static void DrawCube(Vector3 center, float length, Color color, float duration, bool depthTest)
    {
        Vector3 leftBottomBack = new Vector3(center.x - (length / 2f), center.y - (length / 2f), center.z - (length / 2f));
        Vector3 rightTopFront = new Vector3(center.x + (length / 2f), center.y + (length / 2f), center.z + (length / 2f));

        DrawRectPrism(leftBottomBack, rightTopFront, color, duration, depthTest);
    }
    #endregion
}