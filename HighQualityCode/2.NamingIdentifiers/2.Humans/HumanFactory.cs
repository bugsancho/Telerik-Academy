public class HumanFactory
{
    public void CreateHuman(int idNumber)
    {
        Human person = new Human();
        person.Id = idNumber;
        if (idNumber % 2 == 0)
        {
            person.Name = "Батката";
            person.Gender = Gender.Male;
        }
        else
        {
                person.Name = "Мацето";
            person.Gender = Gender.Female;
        }
    }
}