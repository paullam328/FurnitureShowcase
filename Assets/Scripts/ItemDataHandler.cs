using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

public class ItemDataHandler : MonoBehaviour
{
    private string _secretKey = "mySecretKey";
    private string _url = "http://localhost:8000/ServerHandler.php"; //php server in localhost 8000
    public bool _isDataRetrievalDone = false;

    //MySQL ID: showcasedemo
    //MySQL Password: demoShowcase

    public void StartPostIDGetData(Furniture f)
    {
        StartCoroutine(PostIDGetData(f));
    }

    public IEnumerator PostIDGetData(Furniture f)
    {
        string hash = Md5Sum(f.GetId() + _secretKey);
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        //formData.Add(new MultipartFormDataSection("id=" + id/* + "&hash" + hash*/));
        formData.Add(new MultipartFormDataSection("id", f.GetId().ToString()));

        WWWForm form = new WWWForm();
        form.AddField("id", f.GetId());
        using (UnityWebRequest www = UnityWebRequest.Post(_url, formData))
        {
            www.chunkedTransfer = false;////ADD THIS LINE

            DownloadHandlerBuffer dH = new DownloadHandlerBuffer();
            www.downloadHandler = dH;
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log("Get Data Error: " + www.error);
            }
            else
            {
                string results = www.downloadHandler.text;
                ParseResultsArr(results, f);
            }
        }
    }

    private void ParseResultsArr(string results, Furniture f)
    {
        string[] strArr = results.Split('\n');
        string[] keys = new string[] { "name", "description", "rating",
            "original_price", "discount_price", "contact_name",
            "contact_email", "contact_phone", "contact_address"};

        for (int i = 0; i < strArr.Length; i++)
        {
            string key = keys.FirstOrDefault(s=>strArr[i].Contains(s));
            Debug.Log("key: " + key + "| strArr[i]: " + strArr[i]);
            switch (key)
            {
                case "name":
                    {
                        if (strArr[i].Contains("contact_name"))
                        {
                            f._contactName = ParseAttrStr<string>(strArr[i]);
                        }
                        else
                        {
                            f._name = ParseAttrStr<string>(strArr[i]);
                        }
                    }
                    break;
                case "description":
                    f._description = ParseAttrStr<string>(strArr[i]);
                    break;
                case "rating":
                    f._rating = ParseAttrStr<int>(strArr[i]);
                    break;
                case "original_price":
                    f._originalPrice = ParseAttrStr<float>(strArr[i]);
                    break;
                case "discount_price":
                    f._discountPrice = ParseAttrStr<float>(strArr[i]);
                    break;
                case "contact_email":
                    f._contactemail = ParseAttrStr<string>(strArr[i]);
                    break;
                case "contact_phone":
                    f._contactphone = ParseAttrStr<string>(strArr[i]);
                    break;
                case "contact_address":
                    f._contactaddress = ParseAttrStr<string>(strArr[i]);
                    break;
                case "default":
                    break;

            }
        }
    }

    
    private T ParseAttrStr<T>(string val)
    {
        T result = default(T);
        //      [id] => 0       
        // Removed Any NewLine:
        if (val.IndexOf("\n") > -1)
        {

        }
        string processedVal = Regex.Replace(val, @"\n", "");
        int valLen = processedVal.Length - (processedVal.IndexOf('>') + 2);
        string parseStr = processedVal.Substring(processedVal.IndexOf('>') + 2, valLen);

        result = (T) Convert.ChangeType(parseStr, typeof(T));

        return result;
    }

    //For security:
    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // convert encrypted bytes back to str

        string hashStr = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashStr += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashStr.PadLeft(32, '0');

    }
}
