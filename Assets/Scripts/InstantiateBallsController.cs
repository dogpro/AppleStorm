using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InstantiateBallsController : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _startPointTransform;
    
    [SerializeField] private List<Color> _colorList;
    [SerializeField] private List<TriggerController> _binList;
    
    private List<Color> _colorListNOSer = new List<Color>();

    public static Action onSetBall;
    
    private void Start()
    {
        Configure();
        
        onSetBall += BallConfigure;
    }


    private void Configure()
    {
        foreach (var bin in _binList)
        {
            bin.Color = GetColor();
        }

        BallConfigure();
    }

    private void BallConfigure()
    {
        _ball.SetColor(_colorListNOSer[Random.Range(0, _colorListNOSer.Count - 1)]);
        _ball.transform.position = _startPointTransform.position;
    }

    private Color GetColor()
    {
        Color color = _colorList[Random.Range(0, _colorList.Count - 1)];

        if (!_colorListNOSer.Contains(color))
        {
            _colorListNOSer.Add(color);
            return color;
        }

        return GetColor();
    }
}
