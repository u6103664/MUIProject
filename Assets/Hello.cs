using UnityEngine;
using UnityEngine.Events;


public class Hello : MonoBehaviour
{
    [Range(0, 3)] public int num1;
    [SerializeField] private int num2;
    [SerializeField] private OtherType selector;
    private enum OtherType
    {
        Option1,
        Option2, 
        Option3
    }
    void Start()
    {
        Debug.Log("Hello students! :D");
        Debug.LogWarning("This could be problematic! :/");
        Debug.LogError("This is a real problem! >:(");
    }

    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        Debug.Log("Hello!");
        counter+=time.deltaTime;
    }
    public void ButtonClicked(bool print){
        if(print)Debug.Log("Hello!");
        mySlider.value = Random.Range(mySlider.minValue,mySlider.maxValue);

    }
    public void OnSliderChanged(float newValue){
        Debug.Log("New value: "+ newValue);
    }
    public void StartGame(){
        SceneManager.LoadScene("Game");
    }
}
