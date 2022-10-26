using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea3 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (this.transform.position.x >= point)
        {
            SceneManager.LoadScene("stageSea3");
        }
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("stageSea3");
    }
}
