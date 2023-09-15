using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelectionAlgorithm : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cardUpgrade;
    [SerializeField]
    private GameObject[] _cardPositionInGame;


    /*private void Start()
    {
        
    }

    private void Update()
    {
        if (VariableStatic.chooseCard)
        {
            List<GameObject> selectedCard = new List<GameObject>();

            for (int i = 0; i < _cardUpgrade.Length; i++)
            {
                selectedCard.Add(_cardUpgrade[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                int randomIndex = Random.Range(0, selectedCard.Count);

                Instantiate(selectedCard[randomIndex], _cardPositionInGame[i].transform.position, selectedCard[randomIndex].transform.rotation, _cardPositionInGame[0].transform.parent);
                selectedCard.RemoveAt(randomIndex);
            }

            VariableStatic.chooseCard = false;
        }
    }*/

    private int randomIndexMidF;
    private int randomIndexMidS;
    public static int randomIndex;


    private void Start()
    {
        randomIndexMidF = 100;
        randomIndexMidS = 200;
    }

    private void Update()
    {
        if (VariableStatic.chooseCard)
        {

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    randomIndex = Random.Range(0, _cardUpgrade.Length);
                } while (randomIndex == randomIndexMidF || randomIndex == randomIndexMidS);

                if (i == 0)
                {
                    randomIndexMidF = randomIndex;
                }
                if (i == 1)
                {
                    randomIndexMidS = randomIndex;
                }

                Instantiate(_cardUpgrade[randomIndex], _cardPositionInGame[i].transform.position, _cardUpgrade[randomIndex].transform.rotation, _cardPositionInGame[0].transform.parent);
            }

            VariableStatic.chooseCard = false;
        }
    }
}
