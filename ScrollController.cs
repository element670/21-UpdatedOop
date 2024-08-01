using TMPro;
using UnityEngine;
public class ScrollController : MonoBehaviour
{
    private static readonly int minSize = 40;
    private TextMeshProUGUI lastSelectedText;
    [SerializeField] private GameObject content;
    [SerializeField] private TextMeshProUGUI scorePrefab;
    public void AddView(string score)
    {
        if (lastSelectedText != null)
        {
            lastSelectedText.color = Color.white;
        }
       
        var newScore = Instantiate(scorePrefab, content.transform,true);
        
        newScore.color = Color.green;
        newScore.transform.localScale = Vector3.one;
        newScore.text = score;
        newScore.transform.SetParent(content.transform);
        var rect = content.GetComponent<RectTransform>().rect;
      //rect.Set(0f,0f, rect.width, minSize * newScore.transform.childCount);
      //  content.GetComponent<RectTransform>().sizeDelta = new Vector2(rect.width, minSize * newScore.transform.childCount);
        
        content.GetComponent<RectTransform>().rect.Set(0,0,rect.width, minSize );
        lastSelectedText = newScore;
        
        Canvas.ForceUpdateCanvases();
    }

    
}
