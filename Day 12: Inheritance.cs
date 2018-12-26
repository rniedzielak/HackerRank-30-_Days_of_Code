class Student : Person
{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student (string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        testScores = scores;
    }
    
    /*   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    public string Calculate()
    {
        string grade = "";
        int sum = 0;
        for(int i = 0; i < testScores.Length; i++)
        {
            sum += testScores[i];
        }
        int average = sum / testScores.Length;
        if(90 <= average && average<= 100)
        {
            grade = "O";
        }
        else if(80 <= average && average < 90)
        {
            grade = "E";
        }
        else if(70 <= average && average < 80)
        {
            grade = "A";
        }
        else if(55 <= average && average < 70)
        {
            grade = "P";
        }
        else if(40 <= average && average < 55)
        {
            grade = "D";
        }
        else if (average < 40)
        {
            grade = "T";
        }
        else
        {
            Console.WriteLine("Something go wrong...");
        }
        return grade;
    }
}
