using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; 
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List <Question> unansweredQuestions; 
    
    private Question currentQuestion; 
    
    [SerializeField]
    private Text factText;
    
    [SerializeField]
    private Text trueAnswerText;
    
    [SerializeField]
    private Text falseAnswerText;
    
    [SerializeField]
    private Animator animator;
    
    [SerializeField]
    private float timeBetweenQuestions = 3f; 
    
    void Start ()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0) 
        {
            unansweredQuestions = questions.ToList<Question>(); 
        }
        
        SetCurrentQuestion();
    }
    
    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0,unansweredQuestions.Count); 
        currentQuestion = unansweredQuestions[randomQuestionIndex]; 
        
        factText.text = currentQuestion.fact; 
        
        if(currentQuestion.isTrue)
        {
            trueAnswerText.text = "Stimmt genau!"; 
            falseAnswerText.text = "Nicht ganz...";
        } else
        {
            trueAnswerText.text = "Nicht ganz...";
            falseAnswerText.text = "Stimmt genau!";
        }
    }
    
    
    IEnumerator TransitiontoNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion); 
        
        yield return new WaitForSeconds(timeBetweenQuestions);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    
    
    public void UserSelectTrue()
    {
    
        animator.SetTrigger("True");
        if(currentQuestion.isTrue)
        {
            Debug.Log("Stimmt genau!");  
        } else
        {
            Debug.Log("Nicht ganz...");  
        }
        
        StartCoroutine(TransitiontoNextQuestion()); 
        
        Punktestand.instance.AddPoint(); 
    }
        
    public void UserSelectFalse()
    {
        animator.SetTrigger("False"); 
        if(!currentQuestion.isTrue)
        {
            Debug.Log("Stimmt genau!");  
        } else
        {
            Debug.Log("Nicht ganz...");  
        }    
        
        StartCoroutine(TransitiontoNextQuestion());
        
        Punktestand.instance.AddPoint();
    }
}
