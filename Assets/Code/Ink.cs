using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ink : MonoBehaviour
{
    [SerializeField] Sprite[] sps;
    Image img;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        img = GetComponent<Image>();
        for (int i = 0; i < sps.Length; i++)
        {
            img.sprite = sps[i];
            yield return 0;
        }
        img.DOFade(0, 2).OnComplete(() =>
        {
            Destroy(this.gameObject);
        });
    }
}
