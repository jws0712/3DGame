using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direct_Dr_Go : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        KeyEvent(0, KeyCode.Q, "angry");
        KeyEvent(1, KeyCode.A, "angry");

        KeyEvent(0, KeyCode.W, "eye");
        KeyEvent(1, KeyCode.S, "eye");

        KeyEvent(0, KeyCode.E, "sap");
        KeyEvent(1, KeyCode.D, "sap");

        KeyEvent(0, KeyCode.R, "smile");
        KeyEvent(1, KeyCode.F, "smile");
    }

    private void KeyEvent(int type, KeyCode key, string parameter)
    {
        if (Input.GetKeyDown(key))
        {
            string coroutine = type == 0 ? "ParmeterUp" : "ParmeterDown";
            StartCoroutine(coroutine, parameter);
        }
        else if (Input.GetKeyUp(key))
        {
            string coroutine = type == 0 ? "ParmeterUp" : "ParmeterDown";
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator ParmeterUp(string parameter)
    {
        float percent = animator.GetFloat(parameter);

        while (percent < 1)
        {
            percent += Time.deltaTime;
            animator.SetFloat(parameter, percent);

            yield return null;
        }
    }

    private IEnumerator ParmeterDown(string parameter)
    {
        float percent = animator.GetFloat(parameter);

        while (percent > 0)
        {
            percent -= Time.deltaTime;
            animator.SetFloat(parameter, percent);

            yield return null;
        }
    }
}
