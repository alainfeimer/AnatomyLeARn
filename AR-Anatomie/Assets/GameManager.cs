using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; 
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List <Question> unansweredQuestions; 
    
    private Question currentQuestion; 
    
    [SerializeField]
    private Text factText;
    
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
        
        unansweredQuestions.RemoveAt(randomQuestionIndex); 
    }
}
