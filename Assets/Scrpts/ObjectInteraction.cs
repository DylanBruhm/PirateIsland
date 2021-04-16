using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectInteraction : MonoBehaviour
{
    public GameObject startGame;
    public GameObject EndGame;
    public bool Coin = false;
    public GameObject Coin2;
    [Header("Used for objects that give simple info about themselves")]
    public bool info;
    public string message;
    private Text infotext;

    [Header("this object can be picked up")]
    [Space]
    public bool pickup;

    
    [Header("Npc Text")]
    [Space]
    public bool talks;
    [TextArea]
    
    public string[] sentences;
    public string[] sentencesCoin;
    public void Info()
    {

        StartCoroutine(ShowInfo(message, 2.5f));
    }
    public void Pickup()
    {
       
        if (gameObject.name == "Coin")
        {
            Debug.Log("You Picked " + this.gameObject.name);
            this.gameObject.SetActive(false);
        }
        if (Coin2.activeInHierarchy == false && gameObject.name == "Shovel")
        {
            Debug.Log("You Picked " + this.gameObject.name);

            this.gameObject.SetActive(false);

        }
        if (Coin2.activeInHierarchy == false && gameObject.name == "X")
        {
            Debug.Log("You Picked " + this.gameObject.name);

            this.gameObject.SetActive(false);
            WinScreen();

        }
        if (Coin2.activeInHierarchy == false && gameObject.name == "SeaWeed")
        {
            Debug.Log("You Picked " + this.gameObject.name);

            this.gameObject.SetActive(false);

        }
        if (Coin2.activeInHierarchy == false && gameObject.name == "Gem" || Coin2.activeInHierarchy == false && gameObject.name == "Oil")
        {
            Debug.Log("You Picked " + this.gameObject.name);

            this.gameObject.SetActive(false);

        }



    }
    public void Talks()
    {
        if(Coin2.activeInHierarchy == false)
        {
            Coin = true;
        }
        
        if (Coin == true)
        {
            Debug.Log("hello");
        }
        if (Coin == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(sentences);
            
        }
        if (Coin == true)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(sentencesCoin);
            
        }

    }
    IEnumerator ShowInfo(string message, float delay)
    {
        infotext.text = message;
        yield return new WaitForSeconds(delay);
        infotext.text = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        infotext = GameObject.Find("InfoText").GetComponent<Text>();
    }

    void WinScreen()
    {
        EndGame.SetActive(true);
        startGame.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
