using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private float _duration = 0.5f;
    [SerializeField] private Text _moneyText;
    [SerializeField] private GameManager _gameManager;

    private int _money;

    public void ChangeMoney(int amount)
    {
        _money += amount;

        if (_money > 0)
        {
            UpdateText();

            UpdateBar();
        }
        else
        {
            _gameManager.LoseScreen();
        }
    }

    private void UpdateText()
    {
        _moneyText.text = _money.ToString();
    }

    private void UpdateBar()
    {
        StartCoroutine(SmoothChange(_money));
    }

    private IEnumerator SmoothChange(float targetValue)
    {
        float startValue = _smoothSlider.value;

        float elapsed = 0f;

        while (elapsed < _duration)
        {
            elapsed += Time.deltaTime;

            _smoothSlider.value = Mathf.Lerp(startValue, targetValue, elapsed / _duration);

            yield return null;
        }

        _smoothSlider.value = targetValue;
    }
}
