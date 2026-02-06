using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    //public Text questText; // Reference to the UI Text component to display quest information

    private TextMeshProUGUI questStatusText;
    private Text currentQuest; // Example initial quest
    public bool hasReachedCheckpointOne = false;
    public bool hasReachedCheckpointTwo = false;
    public bool hasReachedCheckpointThree = false;
    public bool hasReachedCheckpointFour = false;
    public bool hasReachedCheckpointFive = false;
    public bool hasReachedCheckpointSix = false;
    public bool hasReachedCheckpointSeven = false;
    public bool hasReachedCheckpointEight = false;
    public int hasReachedMaya = 0;
    public int hasReachedBulldog = 0;
    public PlayerInventory playerInventory;
    public Dialogue dialogue;
    public YoungMayaMovement youngMayaMovement;
    public BullDog bullDog;
    public PickGun pickGun;
    public MayaDialogue mayaDialogue;
    public DisplayItem displayItem;
    // Add more checkpoint variables as needed

    void Start ()
    {
        questStatusText = GetComponent<TextMeshProUGUI>();
        UpdateQuestText();
    }
    public void Update()
    {
        UpdateQuestText();
        
    }
    void UpdateQuestText()
    {
        //Debug.Log(youngMayaMovement.questDistance);
        //Debug.Log(youngMayaMovement.detectionRadius);
        if (youngMayaMovement.questDistance <= youngMayaMovement.detectionRadius)
        {
            hasReachedMaya = 1;
            //Debug.Log(hasReachedMaya);
        }
         if (displayItem.isLocked)
        {
           hasReachedBulldog = 1;
        }
     if (!hasReachedCheckpointOne)
        {
            questStatusText.text = "Find Dr. Marcus";
            hasReachedCheckpointOne = true;
        }
        else if (playerInventory.NumberOfDiamonds == 1 && hasReachedCheckpointOne && !hasReachedCheckpointTwo)
        {
            questStatusText.text = "Find the diamonds";
            hasReachedCheckpointTwo = true;
        }
        else if (dialogue.wall.activeSelf == false && hasReachedMaya == 0)
        {
            questStatusText.text = "Find Maya Wong";
            hasReachedCheckpointThree = true;

        }
   
        else if (youngMayaMovement.questDistance <= youngMayaMovement.detectionRadius && hasReachedBulldog == 1 && bullDog.currentHealth >=0)
        {
            questStatusText.text = "Eliminate the bulldog";
            hasReachedCheckpointFour = true;
            //Debug.Log(youngMayaMovement.questDistance);

        }
       
        else if (bullDog.currentHealth <=0 && !pickGun.paintGunInventory.gameObject.activeSelf)
        {
            questStatusText.text = "Find the pesticide gun";
            hasReachedCheckpointFive = true;
        }
          else if (pickGun.paintGunInventory.gameObject.activeSelf)
        {
            questStatusText.text = "Eliminate the boss bee";
            hasReachedCheckpointSix = true;
        }
    }

}
