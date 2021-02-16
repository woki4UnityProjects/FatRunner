using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas startCanvas;
    [SerializeField] private Canvas restartCanvas;
    [SerializeField] private Canvas finishCanvas;
    
    // Start is called before the first frame update
    private void Start()
    {
        startCanvas.enabled = true;
        restartCanvas.enabled = false;
        finishCanvas.enabled = false;
    }

    public void Finish()
    {
        finishCanvas.enabled = true;
    }

    public void Restart()
    {
        restartCanvas.enabled = true;
    }
}
