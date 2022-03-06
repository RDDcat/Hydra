using UnityEngine;

public class PlayerController05 : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("isDie");
            //animator.SetBool();
            //animator.SetFloat();
            //animator.SetInteger();
        }
    }

    public void OnDieEvent()
    {
        Debug.Log("End of Die Animation");
    }
}
