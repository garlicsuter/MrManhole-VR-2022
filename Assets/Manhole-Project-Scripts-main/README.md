# MrManhole-VR-2022
## Question Script
*Give script to each question*

Summary:
- Shuffles answers for each question

Inputs:
- Input four buttonAnswers for all questions
- Different answerLocalPosition if desired
  - Default locations for *four buttons* are given in the script and not visible in the inspector
- Set maxQuestionPoints to total amount of points avaliable for that question

## Scoring Script
*Give script to GameManager*

Summary:
- Randomizes questions for each playthrough
- Decreases score after answering incorrectly
- Calls next question after answering correctly

Inputs:
- Input all questions to totalQuestions
- Set chosenQuestions length to 4

## Score Text
*Give script to GameManager*

Design Notes:
- Names of texts cannot be changed
  - Specific Names: Q1 - Score, Q2 - Score, Q3 - Score, Q4 - Score, and Total Score
- Location, font, font size, etc. can be changed

## Final Notes

**SCRIPT IS NOT READY FOR ALL FIVE QUESTIONS**

Change the three lined comments in Scoring Script after Animation Boss Script is complete

Correct answer buttons call CorrectAnswer() in Scoring Script\
Incorrect answer buttons call IncorrectAnswer() in Scoring Script

Both scripts have Restart() and needs to be called by another script, button, etc.
