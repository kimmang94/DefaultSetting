using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEx
{
    // 현재 씬을 알려주는 기능
    public BaseScene CurrentScne
    {
        get
        {
            return GameObject.FindObjectOfType<BaseScene>();
        }
    }
    // 현재씬을 초기화 하고(혹시모를 메모리 해제), 씬을 불러오는 기능
    public void LoadScene(Define.Scene type)
    {
        CurrentScne.Clear();
        SceneManager.LoadScene(GetSceneName(type));
    }

    // C# Reflection 기능을 이용해 Enum 타입을 String 으로 변환
    private string GetSceneName(Define.Scene type)
    {
       string name = System.Enum.GetName(typeof(Define.Scene), type);
       return name;
    }
    
    // 현재 씬에 데이터들 제거
    public void Clear()
    {
        CurrentScne.Clear();
    }
}
