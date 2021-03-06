using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // These urls are entered in the unity editor directly
    public string tutorialUrl;
    public string issuesUrl;

    // The following functions are all attached to the buttons onClick methods in the editor

    public void StartButton()
    {
        SceneManager.LoadScene("RickRollScene");
    }

    public void TutorialButton()
    {
        // This will open the url, that we entered in the editor, in the browser
        Application.OpenURL(tutorialUrl);
    }

    public void AboutButton()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ReportIssues()
    {
        Application.OpenURL(issuesUrl);
    }

}
