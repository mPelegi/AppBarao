using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{
    [SerializeField] private string nameScene;
    [SerializeField] private InputField nameStudent;
    [SerializeField] private InputField emailStudent;
    [SerializeField] private InputField curseStudent;

    private string name;
    private int register;
    private float score;


    public void HandleBtnNext()
    {
        // PlayerPrefs.SetString("nameStudens", nameStudent.text);
        SceneManager.LoadScene(nameScene);

        // Debug.Log(PlayerPrefs.GetString("nameStudens"));
    }
    private void Start() 
    {
        ExampleSet();
        ExampleGet();
    }

    public void ExampleSet()
    {
        PlayerPrefs.SetString("nameStudent", "Murilo Pelegi Elesbão");
        PlayerPrefs.SetInt("registerStudent", 1887483);
        PlayerPrefs.SetFloat("value",9.5f );
    }
    public void ExampleGet()
    {
      name = PlayerPrefs.GetString("nameStudent");
      register = PlayerPrefs.GetInt("registerStudent");
      score = PlayerPrefs.GetFloat("value");

      Debug.Log("Nome do aluno: " + name + "Matricula do aluno: " + register + "Nota: "+ score);
    }

}
