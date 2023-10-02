using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float _speed = 0;
    
    // 플레이어의 상태 ( 사망관련, 움직임 )
    public enum PlayerState
    {
        Die,
        Moving,
        Idle,
    }
    
    private PlayerState _state = PlayerState.Idle;
    
    // Input Manager 의 KeyAction 등록
    private void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;
    }
    // Player state 에 따라서 분기처리
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
    
    // 키보드 WASD 입력에 따른 디버그 로그 (움직임 기능 구현)
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
    
    // 플레이어 State 에 따른 구현부
    // 움직임을 제외한 (움직임은 OnKeyboard에서 구현) 움직임 애니메이션, 혹은 추가 기능사항 
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
