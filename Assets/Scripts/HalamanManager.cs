using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MulaiPermainan() {
        SceneManager.LoadScene("Main");
    }

    public void KembaliKeMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void KeluarPermainan(){
        Application.Quit();
    }
}
