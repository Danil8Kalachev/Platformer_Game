using TMPro;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _coin.ChangedMoney += OnChangedMoney;
    }

    private void OnDisable()
    {
        _coin.ChangedMoney -= OnChangedMoney;
    }

    private void OnChangedMoney(int countMoney)
    {
        _text.text = countMoney.ToString();
    }
}