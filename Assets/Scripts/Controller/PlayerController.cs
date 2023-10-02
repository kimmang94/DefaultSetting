using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float _speed = 0;
    
    public enum PlayerState
    {
        Die,
        Moving,
        Idle,
    }
    
    private PlayerState _state = PlayerState.Idle;
    
    private void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;
    }
    private void Update()
    {
        switch(_state)
        {
            case PlayerState.Die:
                UpdateDie();
                break;
            case PlayerState.Moving:
                UpdateMoving();
                break;
            case PlayerState.Idle:
                UpdateIdle();
                break;
        }
    }
    
    private void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
    }
    
    private void UpdateDie()
    {
        // 애니메이션
        // 추가기능
    }
    private void UpdateMoving()
    {
        // 애니메이션
        // 추가기능
    }
    private void UpdateIdle()
    {
        // 애니메이션
        // 추가기능
    }
}
