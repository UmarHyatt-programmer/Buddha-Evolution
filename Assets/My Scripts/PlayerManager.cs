using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class PlayerManager : MonoBehaviour
{
    public Slider[] sliders;

    [Header("Charactor value Increment")]
    public int student;
    public int monk, teacher, headPriest, master, buddha;

    [Header("Power")] // 'Power' value is in postive int...
    public int flowerPower;
    public int bookPower, healthyFood;

    [Header("Venom Negative")] // 'Venon' value must be negative int...
    public int meatVenom;
    public int alcoholVenom, womenVenom;

    [Header("Player Health")]
    public int currentHealth;



    public static PlayerManager instance = new PlayerManager();

    void Awake()    // Making singleton
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        // DOTween.To(() => healthSlider.value, x => healthSlider.value = x, currentHealth, slidingTime); //Animation
        AssigningValue();  // Assiging sliders max value  
    }
    void Update()
    {
        if (currentHealth < 0)
        {
            UIManager.instance.gameState = GameState.LevelFail;
        }
    }
    public void UpdateSlider(GameObject obj)
    {
        sliders[0].value = ReturnChangingValue(obj);
        sliders[1].value = ReturnChangingValue(obj);
        sliders[2].value = ReturnChangingValue(obj);
        sliders[3].value = ReturnChangingValue(obj);
        sliders[4].value = ReturnChangingValue(obj);
        sliders[5].value = ReturnChangingValue(obj);
    }

    int ReturnChangingValue(GameObject obj)
    {
        switch (obj.tag)
        {
            // Good things
            case "Lotus":
                return flowerPower + currentHealth;

            case "HealthyFood":
                return healthyFood + currentHealth;

            case "Book":
                return bookPower + currentHealth;

            // Bad things
            case "Meat":
                return meatVenom + currentHealth;

            case "Alcohol":
                return alcoholVenom + currentHealth;

            case "Woman":
                return womenVenom + currentHealth;
            default:
                return 0;
        }
    }

    void AssigningValue()
    {
        //Assinging max value
        sliders[0].maxValue = student;
        sliders[1].maxValue = monk;
        sliders[2].maxValue = teacher;
        sliders[3].maxValue = headPriest;
        sliders[4].maxValue = master;
        sliders[5].maxValue = buddha;

        //Assinging min value
        sliders[0].minValue = 0;
        sliders[1].minValue = student;
        sliders[2].minValue = monk;
        sliders[3].minValue = teacher;
        sliders[4].minValue = headPriest;
        sliders[5].minValue = master;
    }
}
