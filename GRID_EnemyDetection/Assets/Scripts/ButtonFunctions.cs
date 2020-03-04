using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctions : BoolShift
{
    //〔〕︿﹀︹︺〈〉•⋅ ⋗⋖ ⊔⊓⊏⊐  ∧∨ V̇ v̇ ⟑ • □⊡
    // ⟓ ⟔ ⦑ ⦒  「」 ⌜⌝⌞⌟
    // ⋗⋖ ⊔⊓⊏⊐ ⟑ ⩒

    //public bool shiftDot = false;
    public Text textScreen;
    public Color startColor;


    private void Start()
    {
        startColor = gameObject.GetComponent<Renderer>().material.color;
        textScreen.text = "";
    }

    public void Shift()
    {
        if (shiftDot == true)
        {
            shiftDot = false;
            gameObject.GetComponent<Renderer>().material.color = startColor;
        }
        else
        {
            shiftDot = true;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    public void LeftBracket()
    {
        if(shiftDot == true)
        {
            textScreen.text = textScreen.text + "•⊐";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⊐";
        }
    }

    public void RightBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⊏•";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⊏";
        }
    }

    public void UpBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⊔•"; //
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⊔";
        }
    }

    public void DownBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⊓•";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⊓";
        }
    }

    public void CenterBox()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⊡";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "□";
        }
    }

    public void TLeftBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "•⌟";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⌟";
        }
    }
    
    public void TRightBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⌞•";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⌞";
        }
    }

    public void LLeftBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "•⌝";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⌝";
        }
    }

    public void LRightBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⌜•";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "⌜";
        }
    }

    public void VUpBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⩒";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "∨";
        }
    }

    public void VDownBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⟑";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "∧";
        }
    }

    public void VLeftBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⦒";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "〉";
        }
    }

    public void VRightBracket()
    {
        if (shiftDot == true)
        {
            textScreen.text = textScreen.text + "⦑";
            shiftDot = false;
        }
        else
        {
            textScreen.text = textScreen.text + "〈";
        }
    }
}
