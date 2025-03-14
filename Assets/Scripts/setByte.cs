using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class SetByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int myInt;

    private void Start()
    {
        
    }

    void Update()
    {
        myByte.SetValue(myInt);
    }

    public void SetValue(int myValue)
    {
        // hier ga je jouw script schrijven
    }
}
