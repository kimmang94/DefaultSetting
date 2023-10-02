using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Managers : MonoBehaviour
{
    // Manager 스크립트의 유일성을 보장
    static Managers s_instance;
    private static Managers Instance { get { Init(); return s_instance; } } 

    // 각종 매니저들 인스턴스화
    private InputManager _input = new InputManager();
    private ResourceManager _resource = new ResourceManager();
    private SceneManagerEx _scene = new SceneManagerEx();
    private UIManager _ui = new UIManager();
    private SoundManager _sound = new SoundManager();
    // 각종 매니저들 Property 로 값을 갖고와 사용할 수 있게해줌
    public static InputManager Input { get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static SceneManagerEx Scene { get { return Instance._scene; } }
    public static UIManager UI { get { return Instance._ui; } }
    public static SoundManager Sound { get { return Instance._sound; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }
    // SingleTon Pattern 으로 해당 매니저 게임오브젝트가 있으면 그것을 사용하고
    // 없으면 새로운 게임오브젝트에 이름 : @Manangers, Managers 스크립트를 Add해줌
    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }		
    }
    
    // 씬이동, 인풋 등을 초기화 해주는 부분
    public static void Clear()
    {
        Sound.Claer();
        Input.Clear();
        Scene.Clear();
        UI.Clear();
    }
}