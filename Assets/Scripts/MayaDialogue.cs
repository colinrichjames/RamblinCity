using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MayaDialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public float keyDelay = 1f;  // 1 second
    private float timePassed = 0f;

    private int index;

    // inventory
    public CanvasGroup inventoryCanvasGroup;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

       if(Input.GetKey("e") && timePassed >= keyDelay)
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
                timePassed = 0f;
            }
            else
            {
                StopAllCoroutines(); 
                textComponent.text = lines[index];
                timePassed = 0f;
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() 
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else 
        {
            gameObject.SetActive(false);

            // activate InventoryPanel
            inventoryCanvasGroup.interactable = true;
            inventoryCanvasGroup.blocksRaycasts = true;
            inventoryCanvasGroup.alpha = 1f;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
