using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines; 
    public string[] lines_while_diamond_not_complete;
    public string[] lines_complete_diamond_quest;
    public string[] lines_pesticide;
    public float textSpeed;
    public float keyDelay = 1f;  // 1 second
    private float timePassed = 0f;
    public GameObject player_object;
    private bool quest_status = false;
    private bool quest_complete=false;
    private float diamonds_player_collected = 0;
    private bool pesticide_gun_dialogue =false;
    //public bool received_keyboard = false;
    public int diamonds_found;
    public GameObject wall;
    private int index;
    public GameObject keyboard_marcus;
    Collider keyboard_marcus_object_collider;

    public TextMeshProUGUI numberofDiamonds;
    public PlayerInventory playerInventory;
    public InventoryUI inventoryUI;
    public GameObject dr_marcus;
  
 

    // Start is called before the first frame update
    void Start()
    {
        diamonds_found = player_object.GetComponent<PlayerInventory>().NumberOfDiamonds;
        //print(diamonds_found);
        textComponent.text = string.Empty;
        StartDialogue(lines);
        
    }

    // Update is called once per frame
    public void Update()
    {
        timePassed += Time.deltaTime;
        diamonds_found = player_object.GetComponent<PlayerInventory>().NumberOfDiamonds;
        Vector3 player_position = player_object.transform.position;
        Vector3 dr_marcus_position = dr_marcus.transform.position;
        //print(diamonds_found);
        //Debug.Log(diamonds_found);
        //Debug.Log(Vector3.Distance(player_position,dr_marcus_position));

        if(Input.GetKey("e") && timePassed >= keyDelay && ((Vector3.Distance(player_position,dr_marcus_position))<3))
        {
            if((textComponent.text == lines[index]) && (quest_status==false))
            {
                NextLine(lines);
                timePassed = 0f;
            }
            if (wall.activeInHierarchy==false)
            {
                StopAllCoroutines(); 
                textComponent.text = lines[index];
                timePassed = 0f;

            }

           if(quest_status==true && diamonds_found < 12 && quest_complete==false)
           {
             
               textComponent.text = string.Empty;
               index=0;
               gameObject.SetActive(true);
               StartDialogue(lines_while_diamond_not_complete);
               timePassed = 0f;
               

           }
           
           if(quest_status==true && diamonds_found >=12 && quest_complete==false)
           {
               
               index=0;
               textComponent.text = string.Empty;
               gameObject.SetActive(true);
               StartDialogue(lines_complete_diamond_quest);
               quest_complete=true;
               keyboard_marcus_object_collider=keyboard_marcus.GetComponent<Collider>();
               keyboard_marcus_object_collider.isTrigger = true;
               // UPDATE PLAYER INVENTORY
               playerInventory.DiamondsSpent(12);
               inventoryUI.UpdateDiamondTextAfterSpent(playerInventory.NumberOfDiamonds);

               timePassed = 0f;

           }

           if(quest_complete==true && keyboard_marcus == null)
           {
               index=0;
               textComponent.text = string.Empty;
               gameObject.SetActive(true);
               StartDialogue(lines_pesticide);
               wall.SetActive(false);
               timePassed = 0f;
           }



        }
        
    }
    
    void StartDialogue(string[] input_array)
    {
        index=0;
        StartCoroutine(TypeLine(input_array));

    }

    IEnumerator TypeLine(string[] input_array) 
    {
        foreach(char c in input_array[index].ToCharArray())
        {
            textComponent.text +=c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(string[] input_array)
    {
        if(index<input_array.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine(input_array));
        }
        else 
        {
                gameObject.SetActive(false);
                quest_status=true;
 
        }
    }

}
