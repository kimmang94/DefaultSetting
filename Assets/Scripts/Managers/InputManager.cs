using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;
    
        // 키입력이 없으면 return, 키입력이있으면 KeyAction 을 구독 
        public  void OnUpdate()
        {
            if (Input.anyKey == false)
            {
                return;
            }
            if (Input.anyKey != null)
            {
                KeyAction.Invoke();
            }
        }
        
        // 키입력이 필요없는 부분에서 Clear
        // Managers 에 종속되어있는데 이부분으로 키입력이 필요없는 부분에서 메모리 해제
        public void Clear()
        {
            KeyAction = null;
        }
}
