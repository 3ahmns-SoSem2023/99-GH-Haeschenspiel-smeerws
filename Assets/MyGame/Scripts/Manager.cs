using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject startObj;
    public GameObject mainObj;
    [SerializeField] private Rabbit rabbitRed, rabbitWhite, rabbitYellow, rabbitBlue;

    private List<Rabbit> allRabbits = new List<Rabbit>();

    [SerializeField] private Button BtnStartGame;

    public void StartTheGame()
    {
        
        if (rabbitBlue.AgeIsGiven() && 
            rabbitRed.AgeIsGiven() && 
            rabbitWhite.AgeIsGiven() && 
            rabbitYellow.AgeIsGiven())
        {
            startObj.SetActive(false);
            rabbitBlue.transform.SetParent(mainObj.transform);

            rabbitBlue.SetRabbitMainPos();
            rabbitRed.transform.SetParent(mainObj.transform);

            rabbitRed.SetRabbitMainPos();
            rabbitWhite.transform.SetParent(mainObj.transform);

            rabbitWhite.SetRabbitMainPos();
            rabbitYellow.transform.SetParent(mainObj.transform);

            rabbitYellow.SetRabbitMainPos();
            mainObj.SetActive(true);

            allRabbits.Sort((r1, r2) => r1.rabbitAge.CompareTo(r2.rabbitAge));
            foreach (Rabbit a in allRabbits)
            {
                Debug.Log(a.name + "age: " + a.rabbitAge);
                a.SetCurrentTurn(false);
            }

            allRabbits.Last().SetCurrentTurn(true);
        }

        else
        {
            Debug.Log("Name vergessen");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        startObj.SetActive(true);
        mainObj.SetActive(false);

        allRabbits.Add(rabbitBlue);
        allRabbits.Add(rabbitRed);
        allRabbits.Add(rabbitWhite);
        allRabbits.Add(rabbitYellow);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
