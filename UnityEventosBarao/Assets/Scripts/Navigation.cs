using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    //[SerializeField] private string nameSceneNext;
    //[SerializeField] private string nameScenePrevious;
    //[SerializeField] private string nameSceneUp;
    //[SerializeField] private string nameSceneDown;

    //[SerializeField] private Button buttonNext;
    //[SerializeField] private Button buttonPrevious;
    //[SerializeField] private Button buttonUp;
    //[SerializeField] private Button buttonDown;

    //private string nameSceneActual;

    // Start is called before the first frame update
    void Start()
    {
        //nameSceneActual = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void Awake()
    //{
    //    if (!string.IsNullOrWhiteSpace(nameSceneNext))
    //    {
    //        buttonNext.onClick.AddListener(delegate { HandleButton(nameSceneNext); });
    //    }
    //    if (!string.IsNullOrWhiteSpace(nameScenePrevious))
    //    {
    //        buttonPrevious.onClick.AddListener(delegate { HandleButton(nameScenePrevious); });
    //    }
    //    if (!string.IsNullOrWhiteSpace(nameSceneUp))
    //    {
    //        buttonUp.onClick.AddListener(delegate { HandleButton(nameSceneUp); });
    //    }
    //    if (!string.IsNullOrWhiteSpace(nameSceneDown))
    //    {
    //        buttonDown.onClick.AddListener(delegate { HandleButton(nameSceneDown); });
    //    }
    //}

    //void HandleButton(string scene)
    //{
    //    SceneManager.LoadScene(scene, LoadSceneMode.Single);
    //}

    public void MoveToLoginScene()
    {
        SceneManager.LoadScene("1 - Login", LoadSceneMode.Single);
    }

    public void MoveToHomeScene()
    {
        SceneManager.LoadScene("2 - Home", LoadSceneMode.Single);
    }

    public void MoveToWeekOpeningScene()
    {
        SceneManager.LoadScene("3 - WeekOpening", LoadSceneMode.Single);
    }

    public void MoveToWorkshopsScene()
    {
        SceneManager.LoadScene("4 - Workshops", LoadSceneMode.Single);
    }

    public void MoveToWorkshops2Scene()
    {
        SceneManager.LoadScene("4 - Workshops2", LoadSceneMode.Single);
    }

    public void MoveToPresentationsScene()
    {
        SceneManager.LoadScene("5 - Presentations", LoadSceneMode.Single);
    }

    public void MoveToPresentations2Scene()
    {
        SceneManager.LoadScene("5 - Presentations2", LoadSceneMode.Single);
    }

    public void MoveToBaraoCineScene()
    {
        SceneManager.LoadScene("6 - BaraoCine", LoadSceneMode.Single);
    }

    public void MoveToCreditsScene()
    {
        SceneManager.LoadScene("7 - Credits", LoadSceneMode.Single);
    }
}
