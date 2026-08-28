using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text NotiText;
    public static UiManager Instance;

    [SerializeField]
    private GameObject RestartButton;

    [SerializeField]
    private Player player;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }

    void Update()
    {

    }

    public void ShowNotiText(string s)
    {
        NotiText.text = s;
    }

    public void restart()
    {
        player.transform.position = new Vector3(0f, 87.39f, -86.57f);
        player.Hp = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        RestartButton.SetActive(flag);
    }
}
