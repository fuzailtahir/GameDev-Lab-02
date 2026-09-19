using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TriangleGenerator : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();

        // 1. Define the 3 vertices (corner points) of the triangle
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),  // Bottom-left
            new Vector3(0, 1, 0),  // Top-left
            new Vector3(1, 0, 0)   // Bottom-right
        };

        // 2. Connect the vertices in clockwise order to set the front face direction
        int[] triangles = new int[]
        {
            0, 1, 2
        };

        // 3. Assign data to the mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals(); // Recalculates lighting direction

        // 4. Set the mesh to the MeshFilter component
        GetComponent<MeshFilter>().mesh = mesh;
    }
}