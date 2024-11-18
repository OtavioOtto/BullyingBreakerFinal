using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarteiraCollider : MonoBehaviour
{
    [Header("Carteira Configs")]
    public string item;
    public GameObject carteira;
    public GameObject pegouItem;
    public TMP_Text pegouItemTxt;
    public SpriteRenderer carteiraRenderer;
    public GameObject interactTxt;
    [Header("Collider Verifier")]
    [SerializeField] private bool playerIsInside = false;
    public InventoryHandler inventory;
    void Start()
    {
        Transform child = transform.GetChild(0);
        item = child.name;
        carteiraRenderer = carteira.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (playerIsInside) {

            Transform child = transform.GetChild(0);

            if (Input.GetButtonDown("VERDE0") && child.gameObject.activeSelf)
            {
                interactTxt.SetActive(false);
                pegouItemTxt.text = "Pegou: " + item;
                StartCoroutine(GotItem());
                inventory.GotItem(item);
                DeleteChild();
                carteiraRenderer.color = Color.white;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsInside = true;
            if(transform.GetChild(0).gameObject.activeSelf)
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
    public void DeleteChild()
    {
        transform.GetChild(0).gameObject.SetActive(false);

    }

    IEnumerator GotItem() 
    {
        pegouItem.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        pegouItem.SetActive(false);
    }
}