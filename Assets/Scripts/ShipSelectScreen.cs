using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipSelectScreen : MonoBehaviour
{
    public TextMeshProUGUI shipName;
    public TextMeshProUGUI shipName2;
    public TextMeshProUGUI shipName3;
    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider rofSlider; //"Rate of Fire"
    public int chosenShip;
    public ShipData[] shipArray;
    public GameObject[] selectedShip;
    public Button left;
    public Button right;

    private float speed = 0.005f;

    private void OnEnable()
    {
        left.Select();
    }

    void Update()
    {
        //Con esto se cambia el nombre según la nave elegida
        shipName.text = shipArray[chosenShip].spaceshipName;
        shipName2.text = shipArray[chosenShip].spaceshipName;
        shipName3.text = shipArray[chosenShip].spaceshipName;


        if (speedSlider.value < (shipArray[chosenShip].speed - 0.09))
        {
            speedSlider.value += Mathf.Lerp(0, shipArray[chosenShip].speed, speed);
        }
        if (speedSlider.value > (shipArray[chosenShip].speed + 0.09))
        {
            speedSlider.value -= Mathf.Lerp(shipArray[chosenShip].speed, speedSlider.value, speed) / 25;
        }

        if (shieldSlider.value < (shipArray[chosenShip].shield - 0.09))
        {
            shieldSlider.value += Mathf.Lerp(0, shipArray[chosenShip].shield, speed);
        }
        if (shieldSlider.value > (shipArray[chosenShip].shield + 0.09))
        {
            shieldSlider.value -= Mathf.Lerp(shipArray[chosenShip].shield, shieldSlider.value, speed) / 25;
        }

        if (rofSlider.value < (shipArray[chosenShip].rof - 0.09))
        {
            rofSlider.value += Mathf.Lerp(0, shipArray[chosenShip].rof, speed);
        }
        if (rofSlider.value > (shipArray[chosenShip].rof + 0.09))
        {
            rofSlider.value -= Mathf.Lerp(shipArray[chosenShip].rof, rofSlider.value, speed) / 25;
        }

        if (chosenShip == 0)
        {
            selectedShip[0].SetActive(true);
            selectedShip[1].SetActive(false);
            selectedShip[2].SetActive(false);
        }else if (chosenShip == 1)
            {
                selectedShip[0].SetActive(false);
                selectedShip[1].SetActive(true);
                selectedShip[2].SetActive(false);
            }else if (chosenShip == 2)
                {
                    selectedShip[0].SetActive(false);
                    selectedShip[1].SetActive(false);
                    selectedShip[2].SetActive(true);
                }

    }
    public void changeUP()
    {
        chosenShip++;
        if (chosenShip > 2)
        {
            chosenShip = 0;
        }
    }

    public void changeDOWN()
    {
        chosenShip--;
        if (chosenShip < 0)
        {
            chosenShip = 2;
        }
    }
}
