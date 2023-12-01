using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rayito : MonoBehaviour
{
    Text _text;
    public string _texto;
    bool _isClicked = true;
    void Awake()
    {
        _text = GameObject.Find("Canvas").GetComponentInChildren<Text>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity) && Input.GetButtonDown("Fire1"))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.point);
            if(hit.transform.gameObject.tag == "Scene1" && _isClicked == true)
            {
                _isClicked = false;
                StartCoroutine(ContadorScena1());
            }

            if(hit.transform.gameObject.tag == "Scene2" && _isClicked == true)
            {
                _isClicked = false;
                StartCoroutine(ContadorScena2());
            }

            if(hit.transform.gameObject.tag == "Scene3" && _isClicked == true)
            {
                _isClicked = false;
                StartCoroutine(ContadorScena3());
            }
        }

        IEnumerator ContadorScena1()
        {
            _text.text = "5";
            yield return new WaitForSeconds(1);
            _text.text = "4";
            yield return new WaitForSeconds(1);
            _text.text = "3";
            yield return new WaitForSeconds(1);
            _text.text = "2";
            yield return new WaitForSeconds(1);
            _text.text = "1";
            yield return new WaitForSeconds(1);
            _text.text = "0";
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(1);
        }

        IEnumerator ContadorScena2()
        {
            _text.text = "5";
            yield return new WaitForSeconds(1);
            _text.text = "4";
            yield return new WaitForSeconds(1);
            _text.text = "3";
            yield return new WaitForSeconds(1);
            _text.text = "2";
            yield return new WaitForSeconds(1);
            _text.text = "1";
            yield return new WaitForSeconds(1);
            _text.text = "0";
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(2);
        }

        IEnumerator ContadorScena3()
        {
            _text.text = "5";
            yield return new WaitForSeconds(1);
            _text.text = "4";
            yield return new WaitForSeconds(1);
            _text.text = "3";
            yield return new WaitForSeconds(1);
            _text.text = "2";
            yield return new WaitForSeconds(1);
            _text.text = "1";
            yield return new WaitForSeconds(1);
            _text.text = "0";
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(3);
        }
    }
}
