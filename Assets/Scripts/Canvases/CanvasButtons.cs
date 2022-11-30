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

    [SerializeField] GameObject woodKey;
    [SerializeField] GameObject stoneKey;

    [SerializeField] CanvasNumberScript answer;

    [SerializeField] AudioSource source;

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

        source.Play();
    }

    string tempText1 = "W";
    string tempText2 = "W";
    string tempText3 = "W";
    public void OnBtnPressColor(int buttonColor)
    {
        Color orange = new Color(1, 0.5f, 0);
        Color indigo = new Color(0.29f, 0, 0.51f);
        Color violet = new Color(0.61f, 0.15f, 0.71f);
        Color purple = new Color(0.63f, 0.13f, 0.94f);
        Color brown = new Color(0.59f, 0.29f, 0);

        string output = "";


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
                    tempText1 = "R";
                }
                else if (colorTemp1 == 1)
                {
                    button1.GetComponent<Image>().color = orange;
                    tempText1 = "O";
                }
                else if (colorTemp1 == 2)
                {
                    button1.GetComponent<Image>().color = Color.yellow;
                    tempText1 = "Y";
                }
                else if (colorTemp1 == 3)
                {
                    button1.GetComponent<Image>().color = Color.green;
                    tempText1 = "G";
                }
                else if (colorTemp1 == 4)
                {
                    button1.GetComponent<Image>().color = Color.blue;
                    tempText1 = "B";
                }
                else if (colorTemp1 == 5)
                {
                    button1.GetComponent<Image>().color = indigo;
                    tempText1 = "I";
                }
                else if (colorTemp1 == 6)
                {
                    button1.GetComponent<Image>().color = violet;
                    tempText1 = "V";
                }
                else if (colorTemp1 == 7)
                {
                    button1.GetComponent<Image>().color = Color.white;
                    tempText1 = "W";
                }
                else if (colorTemp1 == 8)
                {
                    button1.GetComponent<Image>().color = purple;
                    tempText1 = "P";
                }
                else if (colorTemp1 == 9)
                {
                    button1.GetComponent<Image>().color = brown;
                    tempText1 = "Br";
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
                    button2.GetComponent<Image>().color = Color.red;
                    tempText2 = "R";
                }
                else if (colorTemp2 == 1)
                {
                    button2.GetComponent<Image>().color = orange;
                    tempText2 = "O";
                }
                else if (colorTemp2 == 2)
                {
                    button2.GetComponent<Image>().color = Color.yellow;
                    tempText2 = "Y";
                }
                else if (colorTemp2 == 3)
                {
                    button2.GetComponent<Image>().color = Color.green;
                    tempText2 = "G";
                }
                else if (colorTemp2 == 4)
                {
                    button2.GetComponent<Image>().color = Color.blue;
                    tempText2 = "B";
                }
                else if (colorTemp2 == 5)
                {
                    button2.GetComponent<Image>().color = indigo;
                    tempText2 = "I";
                }
                else if (colorTemp2 == 6)
                {
                    button2.GetComponent<Image>().color = violet;
                    tempText2 = "V";
                }
                else if (colorTemp2 == 7)
                {
                    button2.GetComponent<Image>().color = Color.white;
                    tempText2 = "W";
                }
                else if (colorTemp2 == 8)
                {
                    button2.GetComponent<Image>().color = purple;
                    tempText2 = "P";
                }
                else if (colorTemp2 == 9)
                {
                    button2.GetComponent<Image>().color = brown;
                    tempText2 = "Br";
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
                    button3.GetComponent<Image>().color = Color.red;
                    tempText3 = "R";
                }
                else if (colorTemp3 == 1)
                {
                    button3.GetComponent<Image>().color = orange;
                    tempText3 = "O";
                }
                else if (colorTemp3 == 2)
                {
                    button3.GetComponent<Image>().color = Color.yellow;
                    tempText3 = "Y";
                }
                else if (colorTemp3 == 3)
                {
                    button3.GetComponent<Image>().color = Color.green;
                    tempText3 = "G";
                }
                else if (colorTemp3 == 4)
                {
                    button3.GetComponent<Image>().color = Color.blue;
                    tempText3 = "B";
                }
                else if (colorTemp3 == 5)
                {
                    button3.GetComponent<Image>().color = indigo;
                    tempText3 = "I";
                }
                else if (colorTemp3 == 6)
                {
                    button3.GetComponent<Image>().color = violet;
                    tempText3 = "V";
                }
                else if (colorTemp3 == 7)
                {
                    button3.GetComponent<Image>().color = Color.white;
                    tempText3 = "W";
                }
                else if (colorTemp3 == 8)
                {
                    button3.GetComponent<Image>().color = purple;
                    tempText3 = "P";
                }
                else if (colorTemp3 == 9)
                {
                    button3.GetComponent<Image>().color = brown;
                    tempText3 = "Br";
                }

                break;
            default:
                break;
        }
        output = tempText1 + tempText2 + tempText3;

        CheckCorrectColor(output);

        source.Play();
    }

    public void CheckCorrectNumber()
    {
        string attempt = textOne.text + textTwo.text + textThree.text;
        string correct = GameManager.Instance.GetNumberCode();
        Debug.Log("Attempt: " + attempt + " Correct: " + correct);
        if (attempt.Equals(correct))
        {
            Debug.Log("Correct");
            Instantiate(woodKey, transform.position, transform.rotation);
            Destroy(gameObject.transform.parent.gameObject);
        }
        else
        {
            Debug.Log(attempt + " is not correct");
        }
    }

    public void CheckCorrectColor(string input)
    {
        string attempt = input;
        string correct = GameManager.Instance.GetColorCode();
        Debug.Log("Attempt: " + attempt + " Correct: " + correct);
        if (attempt.Equals(correct))
        {
            Debug.Log("Correct");
            Instantiate(stoneKey, transform.position, transform.rotation);
            Destroy(gameObject.transform.parent.gameObject);
        }
        else
        {
            Debug.Log(attempt + " is not correct");
        }
    }
}
