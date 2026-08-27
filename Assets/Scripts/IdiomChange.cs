using UnityEngine;
using System.Collections;
using UnityEngine.Localization.Settings;

public class IdiomChange : MonoBehaviour
{
    public string textoTraduzido;

    public void AtualizarTexto(string txt)
    {
        textoTraduzido = txt;
    }


    public void MudarIdioma(int idiomaID)
    {
        //LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaID];

        StartCoroutine(MudarIdiomaCoroutine(idiomaID));
    }

    private IEnumerator MudarIdiomaCoroutine(int localId)
    {
        yield return LocalizationSettings.InitializationOperation;

        if (localId >= 0 && localId < LocalizationSettings.AvailableLocales.Locales.Count)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localId];
        }
    }
}