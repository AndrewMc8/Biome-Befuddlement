using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] int numberOfDigits;
    private string correctNumberCode = "";
    private string correctColorCode = "";

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    // Start is called before the first frame update
    void Start()
    {
        setNumberCode();
        setColorCode();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public int randomizer()
    {
        int num;

        num = Random.Range(0, 10);

        return num;
    }

    public void setNumberCode()
    {
        List<int> numbers = new List<int>();
        string text = "";

        for (int i = 0; i < numberOfDigits; i++)
        {
            int randNum = randomizer();

            numbers.Add(randNum);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            text = text + numbers[i].ToString();
        }

        correctNumberCode = text;
    }

    public string GetNumberCode()
    {
        return correctNumberCode;
    }

    public void setColorCode()
    {
        List<int> numbers = new List<int>();
        string text = "";

        for (int i = 0; i < numberOfDigits; i++)
        {
            int randNum = randomizer();

            numbers.Add(randNum);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 0)
            {
                text = text + "R";
            }
            else if (numbers[i] == 1)
            {
                text = text + "O";
            }
            else if (numbers[i] == 2)
            {
                text = text + "Y";
            }
            else if (numbers[i] == 3)
            {
                text = text + "G";
            }
            else if (numbers[i] == 4)
            {
                text = text + "B";
            }
            else if (numbers[i] == 5)
            {
                text = text + "I";
            }
            else if (numbers[i] == 6)
            {
                text = text + "V";
            }
            else if (numbers[i] == 7)
            {
                text = text + "W";
            }
            else if (numbers[i] == 8)
            {
                text = text + "P";
            }
            else if (numbers[i] == 9)
            {
                text = text + "Br";
            }
        }

        correctColorCode = text;
    }

    public string GetColorCode()
    {
        return correctColorCode;
    }
}
