using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class controles : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("btncontroles");
        botao.RegisterCallback<ClickEvent>(OnPlay);
    }

        void OnPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("Controles");
    }
}
