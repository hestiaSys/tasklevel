using UnityEngine;

public class ParticleScreenFit : MonoBehaviour
{
    private ParticleSystem ps;
    
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        AdjustShapeToScreen();
    }
    
    void AdjustShapeToScreen()
    {
        var shape = ps.shape;
        
        // Canvas の Rect Transform を取得
        Canvas canvas = FindObjectOfType<Canvas>();
        RectTransform canvasRect = canvas.GetComponent<RectTransform>();
        
        // 画面幅に合わせてShape のX スケールを設定
        float screenWidth = canvasRect.rect.width / 100f; // 適切にスケール
        shape.scale = new Vector3(screenWidth, 0.1f, 1f);
    }
}