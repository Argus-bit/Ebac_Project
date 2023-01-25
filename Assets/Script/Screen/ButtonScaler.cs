using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = .1f;
    private Vector3 _defultScale;
    private Tween _currentTwee;

    private void Awake()
    {
        _defultScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        _currentTwee = transform.DOScale(_defultScale * finalScale, scaleDuration);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTwee.Kill();
        transform.localScale = _defultScale;
    }
}
