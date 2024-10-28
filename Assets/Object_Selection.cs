using UnityEngine;

public class Object_Selection : MonoBehaviour
{
    public GameObject axePrefab;       // Drag AxePrefab here in the Inspector
    public GameObject surfacePrefab;   // Drag SurfacePrefab here in the Inspector
    public GameObject rockPrefab;      // Drag RockPrefab here in the Inspector
    public void SelectAxe()
    {
        // Remove all child objects
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Instantiate axe as a child of Selection_Object
        Instantiate(axePrefab, transform.position, transform.rotation, transform);
    }

    public void SelectSurface()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        Instantiate(surfacePrefab, transform.position, transform.rotation, transform);
    }

    public void SelectRock()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        Instantiate(rockPrefab, transform.position, transform.rotation, transform);
    }
}
