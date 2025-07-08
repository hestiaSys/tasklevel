using UnityEngine;
using DG.Tweening;

public class TaskDetailPopup : MonoBehaviour
{
    [SerializeField] private RectTransform detailPanel;
    
    void Start()
    {
        // 初期状態：非表示
        gameObject.SetActive(false);
    }
    
    public void ShowPopup()
    {
        gameObject.SetActive(true);
        
        // アニメーション：スケール0から1へ
        detailPanel.localScale = Vector3.zero;
        detailPanel.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
        
        // 背景フェードイン
        GetComponent<CanvasGroup>().alpha = 0f;
        GetComponent<CanvasGroup>().DOFade(1f, 0.2f);
    }
    
    public void HidePopup()
    {
        // アニメーション：スケール1から0へ
        detailPanel.DOScale(0f, 0.2f).SetEase(Ease.InBack);
        
        // 背景フェードアウト
        GetComponent<CanvasGroup>().DOFade(0f, 0.2f)
            .OnComplete(() => gameObject.SetActive(false));
    }
}