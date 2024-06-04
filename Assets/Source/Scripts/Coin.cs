using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _countMoney;

    public event Action<int> ChangedMoney;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
        {
            gameObject.SetActive(false);
            _countMoney++;
            ChangedMoney?.Invoke(_countMoney);
        }
    }
}