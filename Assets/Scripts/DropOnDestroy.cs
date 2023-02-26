using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject dropItemPrefab;
    [SerializeField] [Range(0f, 1f)] float chance = 1f;

    //오브젝트가 게임 끝나고도 지워지지 않을 때.
    bool isQuitting = false;

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }


    private void OnDestroy()
    {
        if (isQuitting)
        {
            return;
        }
        if (Random.value < chance)
        {
            Transform t = Instantiate(dropItemPrefab).transform;
            t.position = transform.position;
        }
    }
}
