namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            // Empty list to handle the output of the number
            List<int> listOfNum = new List<int>();

            //Sum of 3's in the list
            int numOfThree = 0;

            // Sum of 5's in the list
            int numOfFive = 0;

            // if n is equal to one
            if (n == 1)
            {
                Console.WriteLine(-1);
            }

            // if n is greater than one
            else if (n > 1)
            {
                // Populate the empty list with three
                while (listOfNum.Count < n)
                {
                    listOfNum.Add(3);
                }

                // Iterate over the populated list to get the total number of 3's and 5's
                foreach (int item in listOfNum)
                {
                    if (item == 3)
                    {
                        numOfThree++;
                    }
                    else if (item == 5)
                    {
                        numOfFive++;
                    }
                }

                // if the total number of 3 in the list is divided by 5 without remainder print the list
                // Since the list was populated with three we don't need to consider 5 
                if (numOfThree % 5 == 0)
                {
                    Console.WriteLine(string.Join(", ", listOfNum));
                }

                // if the total number of 3 divided by 5 has a remainder
                else
                {
                    // Iterate over the list and change the first number to 5
                    for (int i = 0; i < listOfNum.Count; i++)
                    {
                        listOfNum[i] = 5;

                        // Reset the total number of 3's and 5's to zero
                        numOfThree = 0;
                        numOfFive = 0;

                        // Iterate over the list
                        foreach (int item in listOfNum)
                        {
                            // Count the number of three and 5 in the new list
                            if (item == 3)
                            {
                                numOfThree++;
                            }
                            else if (item == 5)
                            {
                                numOfFive++;
                            }
                        }

                        // If the total number of 3 and 5 are divisible by 5 and 3 respectively
                        if (numOfThree % 5 == 0 && numOfFive % 3 == 0)
                        {
                            Console.WriteLine(string.Join(", ", listOfNum));
                            break;
                        }
                    }
                }
            }
        }
    }
}