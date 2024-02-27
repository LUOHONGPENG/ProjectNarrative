using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//In order to use Coroutine easily, I set game manager as Monobehaviour
public class GameMgr : MonoSingleton<GameMgr>
{

    public bool isInit = false;

    public override void Init()
    {
        StartCoroutine(IE_InitGame());
    }

    public IEnumerator IE_InitGame()
    {

        yield return StartCoroutine(ExcelDataMgr.Instance.IE_Init());

        isInit = true;

        yield break;
    }



}
