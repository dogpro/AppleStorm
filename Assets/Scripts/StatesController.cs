using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class StatesController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI rightText;
    [SerializeField] private TextMeshProUGUI missText;
    
    private int rightCount = 0;
    private int missCount = 0;

    public static Action onRightAction;
    public static Action onMissAction;

    private void Start()
    {
        onRightAction += AddRightCount;
        onMissAction += AddMissCount;
    }

    private void AddRightCount()
    {
        rightCount++;
        VisualUpdate();
    }

    private void AddMissCount()
    {
        missCount++;
        VisualUpdate();
    }

    private void VisualUpdate()
    {
        rightText.text = rightCount.ToString();
        missText.text = missCount.ToString();
    }
}