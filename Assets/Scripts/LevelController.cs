using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : Singleton<LevelController>
{  
    public void LevelBoost()
    {
       GameManager.Instance.GameLevel += 1;
        UiManager.Instance.LevelPrint();
    }
}
