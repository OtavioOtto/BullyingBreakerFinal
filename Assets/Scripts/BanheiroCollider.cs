using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BanheiroCollider : MonoBehaviour
{
    public GameObject banheiroUI;
    public GameObject banheiroUITxt;
    public GameObject salvandoTxtGM;
    public TMP_Text salvandoTxt;
    public Transform spawnPoint;
    [SerializeField] private bool isPlayerInside;
    public bool canChangeUIState = true;
    PlayerController playerController;
    public InventoryHandler inventory;
    float x;
    float y;
    float z;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        x = spawnPoint.transform.position.x;
        y = spawnPoint.transform.position.y;
        z = spawnPoint.transform.position.z - 5;
    }
    private void Update()
    {
        if (Input.GetButtonDown("BRANCO0") && isPlayerInside && !banheiroUI.activeSelf)
        {
            banheiroUI.SetActive(true);
            playerController.canMove = false;
            canChangeUIState = false;
            StartCoroutine(ChangeUIStateCooldown());
        }

        if (!banheiroUI.activeSelf)
        {
            playerController.canMove = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInside = true;
            salvandoTxtGM.SetActive(false);
            PlayerPrefs.SetFloat("PositionX", x);
            PlayerPrefs.SetFloat("PositionY", y);
            PlayerPrefs.SetFloat("PositionZ", z);
            PlayerPrefs.SetInt("SpawnMudado", 1);
            StopCoroutine(SalvandoTxt());
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!banheiroUI.activeSelf)
        {

            banheiroUITxt.SetActive(true);

        }

        else if (banheiroUI.activeSelf)
        {

            banheiroUITxt.SetActive(false);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            isPlayerInside = false;
            banheiroUITxt.SetActive(false);
            salvandoTxtGM.SetActive(true);
            StartCoroutine(SalvandoTxt());
        }
    }

    IEnumerator SalvandoTxt() {

        for (int i = 0; i < 3; i++) {

            salvandoTxt.SetText("Salvando.");
            yield return new WaitForSeconds(0.5f);
            salvandoTxt.SetText("Salvando..");
            yield return new WaitForSeconds(0.5f);
            salvandoTxt.SetText("Salvando...");
            yield return new WaitForSeconds(0.5f);


        }
        salvandoTxtGM.SetActive(false);
    }

    IEnumerator ChangeUIStateCooldown() {
        yield return new WaitForSeconds(0.25f);
        canChangeUIState = true;
    }
}
