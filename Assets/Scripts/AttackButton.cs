using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AttackButton : UIElement
{
    public GameObject attackMenuCanvas;
    public bool isShowing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    
    {
        
    }
    protected override void OnButtonClick()
    {
        base.OnButtonClick();
        isShowing = true;
        attackMenuCanvas.SetActive(isShowing);
    }

}
