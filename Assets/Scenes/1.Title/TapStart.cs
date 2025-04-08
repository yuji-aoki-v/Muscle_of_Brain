using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TapStart : MonoBehaviour, IPointerClickHandler
{
    public string sceneToLoad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Text Clicked!");
        SceneManager.LoadScene(sceneToLoad);
    }
}
