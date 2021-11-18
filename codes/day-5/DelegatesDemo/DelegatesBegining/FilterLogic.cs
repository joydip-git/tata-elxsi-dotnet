namespace DelegatesBegining
{
    class FilterLogic
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public bool IsGreaterThanFive(int number)
        {
            return number > 5;
        }

        public bool IsMarksGreaterThanSeventy(Student s)
        {
            return s.Marks > 70;
        }
    }
}
