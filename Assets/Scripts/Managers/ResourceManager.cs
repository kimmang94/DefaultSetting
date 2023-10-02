using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    // Resources 를 Load하는 부분
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    // Prefab 의 path 를 받고, 만약 부모객체 하위로 생성해야한다면 parent 를 추가하여 사용
    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefeb = Load<GameObject>($"Prefabs/{path}");
        if (prefeb == null)
        {
            Debug.Log($"Failed to load Prefab : {path}");
            return null;
        }

        return Object.Instantiate(prefeb, parent);
    }

    // Instantiate된 오브젝트 혹은 오브젝트를 제거하는 코드
    public void Destroy(GameObject go)
    {
        if (go == null)
        {
            return;
        }

        Object.Destroy(go);
    }
}