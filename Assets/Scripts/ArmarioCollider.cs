using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmarioCollider : MonoBehaviour
{
    [Header("Collider Verifier")]
    [SerializeField] private bool playerIsInside = false;
    [Header("UI Object")]
    [SerializeField] private GameObject uiPapel;
    [SerializeField] private GameObject objPapel;
    public string qualPapel;
    PapelAnimation papelAnimation;
    UIPapelHandler uiPapelHandler;
    
    public InventoryHandler inventory;
    public GameObject interactTxt;
    void Start()
    {
        uiPapelHandler = uiPapel.GetComponent<UIPapelHandler>();
        papelAnimation = objPapel.GetComponent<PapelAnimation>();
        Transform child = transform.GetChild(0);
        qualPapel = child.name;

        if (qualPapel == "um" && inventory.papel1)
            this.gameObject.SetActive(false);
        else if (qualPapel == "dois" && inventory.papel2)
            this.gameObject.SetActive(false);
        else if (qualPapel == "tres" && inventory.papel3)
            this.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (playerIsInside)
        {

            if (Input.GetButtonDown("VERDE0"))
            {
                interactTxt.SetActive(false);
                uiPapelHandler.SetText(qualPapel);
                papelAnimation.AtivarDesativarUI();
                papelAnimation.closing = false;
                papelAnimation.Animate();
                

                if (qualPapel == "um")
                {
                    inventory.papel1 = true;
                }

                else if (qualPapel == "dois")
                {
                    inventory.papel2 = true;
                }

                else if (qualPapel == "tres")
                {
                    inventory.papel3 = true;
                }
            }

            if (Input.GetButtonDown("BRANCO0"))
            {
                this.gameObject.SetActive(false);
                papelAnimation.closing = true;
                papelAnimation.Animate();
            }
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInside = true;
            interactTxt.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInside = false;
            interactTxt.SetActive(false);
        }
    }
}