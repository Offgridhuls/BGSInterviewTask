using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueComponent : MonoBehaviour
{
    public Dialogue dialogue;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerBehaviour PlayerObject = collision.GetComponent<PlayerBehaviour>();
        if (PlayerObject != null)
        {
            TriggerDialogue();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<Shop>().CloseShopGUI();
        EndDialogue();
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    public void EndDialogue()
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
    }

}
