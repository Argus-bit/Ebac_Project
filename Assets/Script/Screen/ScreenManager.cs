using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.UI;
using EBAC.Core.Singleton;
using TMPro;

namespace Screens 
{ 
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBases;
        public List<GameObject> obj;
        public ScreenType startScreen = ScreenType.Painel;
        private ScreenBase _currentScreen;
        public Vector3 vec;
        private GameObject index;

        private void Start()
        {
            HideAll();
            ShowByType(startScreen);


        }

        [Button]
        public void Randomizar()
        {
            Debug.Log("OK");
            index = obj.GetRandom();
            index.SetActive(true);
        }
        [Button]
        public void Limpar()
        {
            obj[0].SetActive(false);
            obj[1].SetActive(false);
            obj[2].SetActive(false);
        }

        /*private void GetRandom()
        {
            screenBases[Random.Range(0, screenBases.Count)].animationDuration = 1;
        }*/
        private void Scale(Transform t,float size = 1.2f)
        {
            t.localScale = Vector3.one * size;
        }

        public void ShowByType(ScreenType type)
        {
            if (_currentScreen != null) _currentScreen.Hide();
            var nextScreen = screenBases.Find(i => i.screenType == type);
            nextScreen.Show();
            _currentScreen = nextScreen;

        }
        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    }
}
