using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//에디터에서 이 스크립터블 오브젝트의 인스턴스를 생성할 수 있다.
[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string Name;
    public int armor;

    public void Equip(Character character)
    {
        character.armor += armor;
    }

    public void UnEquip(Character charater)
    {
        charater.armor -= armor;
    }
}
