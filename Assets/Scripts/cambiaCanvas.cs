using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cambiaCanvas : MonoBehaviour
{
    public Canvas cInicio;
    public Canvas cStart;
    public Canvas cInstr;
    public Canvas cTurnoff;


    private void Start()
    {
        cStart.enabled = false;
        cInstr.enabled = false;
        cTurnoff.enabled = false;
        cInicio.enabled = true;
    }
    public void ActivateStart()
    {
        cStart.enabled = true;
        cInstr.enabled = false;
        cTurnoff.enabled = false;
        cInicio.enabled = false;
    }

    public void ActivateInstructions()
    {
        cStart.enabled = false;
        cInstr.enabled = true;
        cTurnoff.enabled = false;
        cInicio.enabled = false;
    }

    public void Turnoff()
    {
        cStart.enabled = false;
        cInstr.enabled = false;
        cTurnoff.enabled = true;
        cInicio.enabled = false;
    }

    public void Inicio()
    {
        cStart.enabled = false;
        cInstr.enabled = false;
        cTurnoff.enabled = false;
        cInicio.enabled = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Scene escenaActual = SceneManager.GetActiveScene();
        SceneManager.LoadScene(escenaActual.buildIndex + 1);
    }
}
