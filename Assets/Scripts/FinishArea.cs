using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : Singleton<FinishArea>
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Oyuncu objesini kontrol et
        {
            // GameManager üzerinden iþlemi tetikle
            GameManager.Instance.OnPlayerEnterFinishArea(other.gameObject);
        }
    }
}
