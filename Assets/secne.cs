using UnityEngine;
using UnityEngine.SceneManagement;  
public class secne : MonoBehaviour
{
    public void LoadScene(string scncename)
    {
        SceneManager.LoadScene("遊戲畫面");
    }
}
