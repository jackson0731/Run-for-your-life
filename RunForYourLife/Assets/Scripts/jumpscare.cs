using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpscare : MonoBehaviour
{
    public Vector3 targetPosition;
    public float moveTime;

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }

    private IEnumerator MoveCoroutine()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0.0f;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = targetPosition;

        if(transform.position == targetPosition)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene("Dead");
        }
    }
}
