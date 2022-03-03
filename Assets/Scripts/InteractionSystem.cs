using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [Header("Detection Parameters")]
    //DetectionPoint
    public Transform detectionPoint;

    //DetectionRadius
    private const float detectionRadius = 0.2f;

    //DetectionLayer
    public LayerMask detectionLayer;

    //Cached Trigger Object
    public GameObject detectedObject;

    [Header("Others")]
    //list of picked items
    public List<GameObject> pickedItems = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                detectedObject.GetComponent<Item>().Interact();
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        Collider2D obj =  Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
        if (obj == null)
        {
            detectedObject = null;
            return false;
        }
        else
        {
            detectedObject = obj.gameObject;
            return true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }

    public void PickUpItem(GameObject item)
    {
        pickedItems.Add(item);
    }
}
