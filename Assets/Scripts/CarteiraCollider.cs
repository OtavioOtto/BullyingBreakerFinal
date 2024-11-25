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
    public GameObject pao;
    public GameObject biscoito;
    public GameObject energetico;
    public GameObject sanduiche;
    public GameObject chocolate;
    public GameObject melancia;
    public GameObject sobremesa;
    public GameObject cafe;
    public GameObject kit;
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

            if (Input.GetButtonDown("VERMELHO0") && child.gameObject.activeSelf)
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
        if (pao.activeSelf)
            pao.SetActive(false);

        else if (biscoito.activeSelf)
            biscoito.SetActive(false);

        else if (energetico.activeSelf)
            energetico.SetActive(false);

        else if (sanduiche.activeSelf)
            sanduiche.SetActive(false);

        else if (chocolate.activeSelf)
            chocolate.SetActive(false);

        else if (melancia.activeSelf)
            melancia.SetActive(false);

        else if (sobremesa.activeSelf)
            sobremesa.SetActive(false);

        else if (cafe.activeSelf)
            cafe.SetActive(false);

        else if (kit.activeSelf)
            kit.SetActive(false);

        if (item == "pao")
            pao.SetActive(true);

        else if (item == "biscoito")
            biscoito.SetActive(true);

        else if (item == "energetico")
            energetico.SetActive(true);

        else if (item == "sanduiche")
            sanduiche.SetActive(true);

        else if (item == "chocolate")
            chocolate.SetActive(true);

        else if (item == "melancia")
            melancia.SetActive(true);

        else if (item == "sobremesa")
            sobremesa.SetActive(true);

        else if (item == "cafe")
            cafe.SetActive(true);

        else if (item == "kit")
            kit.SetActive(true);

        pegouItem.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        pegouItem.SetActive(false);
        pao.SetActive(false);
        biscoito.SetActive(false);
        energetico.SetActive(false);
        sanduiche.SetActive(false);
        chocolate.SetActive(false);
        melancia.SetActive(false);
        sobremesa.SetActive(false);
        cafe.SetActive(false);
        kit.SetActive(false);
    }
}