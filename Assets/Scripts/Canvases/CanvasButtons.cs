using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasButtons : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text textOne;
    [SerializeField] TMPro.TMP_Text textTwo;
    [SerializeField] TMPro.TMP_Text textThree;

    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;

    [SerializeField] CanvasNumberScript answer;

    int colorTemp1;
    int colorTemp2;
    int colorTemp3;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBtnPressNumber(int buttonNum)
    {
        int temp;
        switch(buttonNum)
        {
            case 1:
                temp = int.Parse(textOne.text);
                temp++;
                if(temp > 9)
                {
                    temp = 0;
                }

                textOne.text = temp.ToString();
                break;
            case 2:
                temp = int.Parse(textTwo.text);
                temp++;
                if (temp > 9)
                {
                    temp = 0;
                }

                textTwo.text = temp.ToString();
                break;
            case 3:
                temp = int.Parse(textThree.text);
                temp++;
                if (temp > 9)
                {
                    temp = 0;
                }

                textThree.text = temp.ToString();
                break;
            default:
                break;
        }
        CheckCorrectNumber();
    }

    public void OnBtnPressColor(int buttonColor)
    {
        Color orange = new Color(1, 0.5f, 0);
        Color indigo = new Color(0.29f, 0, 0.51f);
        Color violet = new Color(0.93f, 0.51f, 0.93f);
        Color purple = new Color(0.63f, 0.13f, 0.94f);
        Color brown = new Color(0.59f, 0.29f, 0);


        switch (buttonColor)
        {
            case 1:
                colorTemp1++;
                if (colorTemp1 > 9)
                {
                    colorTemp1 = 0;
                }

                if (colorTemp1 == 0)
                {
                    button1.GetComponent<Image>().color = Color.red;
                }
                else if (colorTemp1 == 1)
                {
                    button1.GetComponent<Image>().color = orange;
                }
                else if (colorTemp1 == 2)
                {
                    button1.GetComponent<Image>().color = Color.yellow;
                }
                else if (colorTemp1 == 3)
                {
                    button1.GetComponent<Image>().color = Color.green;
                }
                else if (colorTemp1 == 4)
                {
                    button1.GetComponent<Image>().color = Color.blue;
                }
                else if (colorTemp1 == 5)
                {
                    button1.GetComponent<Image>().color = indigo;
                }
                else if (colorTemp1 == 6)
                {
                    button1.GetComponent<Image>().color = violet;
                }
                else if (colorTemp1 == 7)
                {
                    button1.GetComponent<Image>().color = Color.white;
                }
                else if (colorTemp1 == 8)
                {
                    button1.GetComponent<Image>().color = purple;
                }
                else if (colorTemp1 == 9)
                {
                    button1.GetComponent<Image>().color = brown;
                }

                break;
            case 2:
                colorTemp2++;
                if (colorTemp2 > 9)
                {
                    colorTemp2 = 0;
                }

                if (colorTemp2 == 0)
                {
                    button1.GetComponent<Image>().color = Color.red;
                }
                else if (colorTemp2 == 1)
                {
                    button1.GetComponent<Image>().color = orange;
                }
                else if (colorTemp2 == 2)
                {
                    button1.GetComponent<Image>().color = Color.yellow;
                }
                else if (colorTemp2 == 3)
                {
                    button1.GetComponent<Image>().color = Color.green;
                }
                else if (colorTemp2 == 4)
                {
                    button1.GetComponent<Image>().color = Color.blue;
                }
                else if (colorTemp2 == 5)
                {
                    button1.GetComponent<Image>().color = indigo;
                }
                else if (colorTemp2 == 6)
                {
                    button1.GetComponent<Image>().color = violet;
                }
                else if (colorTemp2 == 7)
                {
                    button1.GetComponent<Image>().color = Color.white;
                }
                else if (colorTemp2 == 8)
                {
                    button1.GetComponent<Image>().color = purple;
                }
                else if (colorTemp2 == 9)
                {
                    button1.GetComponent<Image>().color = brown;
                }

                break;
            case 3:
                colorTemp3++;
                if (colorTemp3 > 9)
                {
                    colorTemp3 = 0;
                }

                if (colorTemp3 == 0)
                {
                    button1.GetComponent<Image>().color = Color.red;
                }
                else if (colorTemp3 == 1)
                {
                    button1.GetComponent<Image>().color = orange;
                }
                else if (colorTemp3 == 2)
                {
                    button1.GetComponent<Image>().color = Color.yellow;
                }
                else if (colorTemp3 == 3)
                {
                    button1.GetComponent<Image>().color = Color.green;
                }
                else if (colorTemp3 == 4)
                {
                    button1.GetComponent<Image>().color = Color.blue;
                }
                else if (colorTemp3 == 5)
                {
                    button1.GetComponent<Image>().color = indigo;
                }
                else if (colorTemp3 == 6)
                {
                    button1.GetComponent<Image>().color = violet;
                }
                else if (colorTemp3 == 7)
                {
                    button1.GetComponent<Image>().color = Color.white;
                }
                else if (colorTemp3 == 8)
                {
                    button1.GetComponent<Image>().color = purple;
                }
                else if (colorTemp3 == 9)
                {
                    button1.GetComponent<Image>().color = brown;
                }

                break;
            default:
                break;
        }
        CheckCorrectColor();
    }

    public void CheckCorrectNumber()
    {
        string attempt = textOne.text + textTwo.text + textThree.text;
        string correct = GameManager.Instance.GetNumberCode();
        Debug.Log("Attempt: " + attempt + " Correct: " + correct);
        if (attempt.Equals(correct))
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log(attempt + " is not correct");
        }
    }

    public void CheckCorrectColor()
    {
        string attempt = textOne.text + textTwo.text + textThree.text;
        string correct = GameManager.Instance.GetColorCode();
        Debug.Log("Attempt: " + attempt + " Correct: " + correct);
        if (attempt.Equals(correct))
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log(attempt + " is not correct");
        }
    }
}
