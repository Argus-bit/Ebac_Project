using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = .1f;

    public string phrase;

    private void Awake()
    {
        textMesh.text = "";

    }
    private void Start()
    {
        StartCoroutine(Type(phrase));
    }
    [NaughtyAttributes.Button]
    public void StartTyper()
    {
        StartCoroutine(Type(phrase));
    }
    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach(char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
