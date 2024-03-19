using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image itemPrefab; 
    public Color[] itemColors; 

    private RectTransform contentRect; 

    void Start()
    {
        if (itemPrefab == null || itemColors.Length == 0)
        {
            Debug.LogError("Please assign item prefab and color array!");
            return;
        }

        contentRect = GetComponentInParent<ScrollRect>().content; 

        // Loop through colors and instantiate items
        for (int i = 0; i < itemColors.Length; i++)
        {
            Image newItem = Instantiate(itemPrefab, contentRect); // Instantiate inside Scroll Rect's content
            newItem.color = itemColors[i]; // Set the color of the new item
        }
    }
}