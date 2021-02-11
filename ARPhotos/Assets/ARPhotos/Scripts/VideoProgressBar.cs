using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

/* This class controls the progress bar in terms of updating the progress and recognizing point events.

*  Based on: https://unity3d.college/2018/04/25/unity-video-player-controls-time-scrubber/

*  By: Jason Weimann */

public class VideoProgressBar : MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerDownHandler
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    private Image progress;
    
    private void Awake()
    {
        progress = GetComponent<Image>();
    }

    private void Update()
    {
        if (videoPlayer.frameCount > 0)
            progress.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            progress.rectTransform, eventData.position, Camera.main , out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            UnityEngine.Debug.Log("rect.xMin: " + progress.rectTransform.rect.xMin);
            UnityEngine.Debug.Log("rect.xMax: " + progress.rectTransform.rect.xMax);
            UnityEngine.Debug.Log("Local point x : " + localPoint.x);
            SkipToPercent(pct);
        }
    }

    private void SkipToPercent(float pct)
    {
        UnityEngine.Debug.Log("pct : " + pct);
        var frame = videoPlayer.frameCount * pct;
        videoPlayer.frame = (long)frame;
    }
}