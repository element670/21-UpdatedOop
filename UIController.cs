using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject PanelHolder;
    [SerializeField] private GameObject UnknownPeopleHolder;

    // [SerializeField] private TextMeshProUGUI myScore;
    [SerializeField] private TextMeshProUGUI aiScore;
    [SerializeField] private TextMeshProUGUI result;
    
    [SerializeField] private Button addOne;
    [SerializeField] private Button addTwo;
    [SerializeField] private Button addThree;
    [SerializeField] private Row row;
    [SerializeField] private ScrollController scrollControllerPlayer;
    [SerializeField] private ScrollController scrollControllerAI;
    [SerializeField] private float speed = 150;
    public void MatchMaking(Action matchmakingFinish)
    {
        row.StartRotation(matchmakingFinish, speed);
    }
    public void HidePeopleSearchPanel()
    {
        PanelHolder.SetActive(false);
        UnknownPeopleHolder.SetActive(false);
    }

    public void SetInteractable(bool active)
    {
        addOne.interactable = active;
        addTwo.interactable = active;
        addThree.interactable = active;
    }

    public void SetActiveButtons(bool active)
    {
        addOne.gameObject.SetActive(active);
        addTwo.gameObject.SetActive(active);
        addThree.gameObject.SetActive(active);
    }
    public void SetMyScore(int value)
    {
        scrollControllerPlayer.AddView(value.ToString());
       // myScore.text += $"\n{value}";
    }

    public void SetAIScore(int value)
    {
        scrollControllerAI.AddView(value.ToString());
       // aiScore.text += $"\n{value}";
    }

    public void SetResult(int value)
    {
        result.text = value.ToString();
    }
}
