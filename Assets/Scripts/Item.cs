using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    //collider trigger
    //interaction type

    public enum InteractionType { NONE, PickUp, Examine }
    public InteractionType type;
<<<<<<< HEAD
    [Header("Examine")]
    public string descriptionText;

=======
>>>>>>> e5c9e999ec2db33629d0c31ad2ecd7dad2d30b38

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 11;
    }

    public void Interact()
    {
        switch (type)
        {
            
            case InteractionType.PickUp:
                //add the item to the pickup item list
                FindObjectOfType<InteractionSystem>().PickUpItem(gameObject);
                //delete it
                gameObject.SetActive(false);
                break;
            case InteractionType.Examine:
                Debug.Log("EXAMINE");
                break;
            default:
                Debug.Log("NULL ITEM");
                break;
        }
    }
}
