using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class NPC_Dialogue : MonoBehaviour
{
    public string[] dialogueNPC;
    public int dialogueIndex;

    [SerializeField]private GameObject dialoguePanel;
    public TMP_Text dialogueText;

    [SerializeField]private TMP_Text nameNPC;
    public Image imageNPC;
    public Sprite spriteNPC;

    public bool readyToSpeak;
    public bool startDialogue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && readyToSpeak)
        {
            if (!startDialogue)
            {
                FindAnyObjectByType<MovementPlayer>().moveSpeed = 0f;
                FindAnyObjectByType<MovementPlayer>().Speed = 0f;
                StartDialogue();
            }
            else if (dialogueText.text == dialogueNPC[dialogueIndex])
            {
                NextDialogue();
            }

        }
    }
    void NextDialogue()
    {
        dialogueIndex++;
        if (dialogueIndex < dialogueNPC.Length)
        {
            StartCoroutine(ShowDialogue());
        }
        else
        {
            dialoguePanel.SetActive(false);
            startDialogue = false;
            dialogueIndex = 0;
            FindAnyObjectByType<MovementPlayer>().moveSpeed = 5f;
        }
    }
    void StartDialogue()
    {
        nameNPC.text = "";
        imageNPC.sprite = spriteNPC;
        startDialogue = true;
        dialogueIndex = 0;
        dialoguePanel.SetActive(true);
        StartCoroutine(ShowDialogue());
    }
    IEnumerator ShowDialogue()
    {
        dialogueText.text = "";
        foreach (char letter in dialogueNPC[dialogueIndex])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = false;

        }
    }
}
