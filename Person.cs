namespace Method_Class;

public class Person
{
    public virtual string PersonalData(string firstName, string lastName, int age, string gender)
    {
        return $"FirstName: {firstName}\n LastName: {lastName}\n Age: {age}\n Gender: {gender}";
    }
}