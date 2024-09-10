using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 公共属性：不同的UI元素
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject Scoreboard;
    public Text ScoreText;
    public Text MessageText;

    // 显示主菜单
    public void ShowMainMenu()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
        Scoreboard.SetActive(false);
    }

    // 隐藏主菜单
    public void HideMainMenu()
    {
        MainMenu.SetActive(false);
    }

    // 显示设置菜单
    public void ShowSettingsMenu()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    // 隐藏设置菜单
    public void HideSettingsMenu()
    {
        SettingsMenu.SetActive(false);
    }

    // 更新记分板
    public void UpdateScore(int score)
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + score.ToString();
        }
    }

    // 显示提示信息
    public void DisplayMessage(string message)
    {
        if (MessageText != null)
        {
            MessageText.text = message;
            MessageText.gameObject.SetActive(true);

            // 选择在3秒后隐藏消息（可以根据需求调整时间）
            Invoke(nameof(HideMessage), 3f);
        }
    }

    // 隐藏提示信息
    private void HideMessage()
    {
        MessageText.gameObject.SetActive(false);
    }
}
