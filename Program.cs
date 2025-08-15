namespace _6622780821_lab01_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //--Ex1--
            /*
            Console.Write("Enter first number: ");
            int FNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int SNum = Convert.ToInt32(Console.ReadLine());

            int MNum = Math.Max(FNum,SNum);
            Console.Write("The greatest number is: "+MNum);
            */

            //--Ex2--
            /*
            int i = 0;
            int ans = 0;
            Console.Write("Enter a positive integer: ");
            int tarNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum odd or even numbers? (odd/even): ");
            String choice = Console.ReadLine();

            if (choice == "odd")
            {
                while (i <= tarNum)
                {
                    if (i%2 == 1)
                    {
                        ans += i;
                    }
                    i++;
                }
            } else
            {
                while (i <= tarNum)
                {
                    if (i % 2 == 0)
                    {
                        ans += i;
                    }
                    i++;
                }
            }
            Console.Write("Sum of " + choice + " number upto " + tarNum + "= " + ans);
            i = 0;
            ans = 0;
            */

            //--Ex3--
            /*
            Console.Write("Enter the number of elements in the array: ");
            int arrLen = Convert.ToInt32(Console.ReadLine());
            int[] mainArr = new int[arrLen];

            Console.WriteLine("Enter "+arrLen+" integer elements: ");
            for (int i = 0; i < arrLen; i++)
            {
                Console.Write($"Element {i + 1}: ");
                mainArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sumArr = 0;
            int maxArr = mainArr[0];
            int minArr = mainArr[0];
            foreach (int i in mainArr)
            {
                sumArr += i;

                if (i > maxArr)
                {
                    maxArr = i;
                }

                if (i < minArr)
                {
                    minArr = i;
                }
            }
            float avgArr = (float) sumArr / arrLen;
            Console.WriteLine("Sum of elements: " + sumArr);
            Console.WriteLine("Maximum element: " + maxArr);
            Console.WriteLine("Minimum element: " + minArr);
            Console.WriteLine("Average of elements: " + avgArr);
            */

            //--Ex4--
            /*
            Console.Write("Enter the number of students: ");
            double stuNum = Convert.ToDouble(Console.ReadLine());
            double classSum = 0;
         
            for (int i = 0; i < stuNum; i++)
            {
                Console.Write($"Enter the score for student {i + 1}: ");
                classSum += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"The class average is: {Math.Round((classSum/stuNum),2)}");
            */

            //--Ex5--

            double totalPrice = 0;
            Console.Write("Enter the number of items you want to add: ");
            int itemAmount = Convert.ToInt32(Console.ReadLine());
            int[] cart = new int[itemAmount];
            for (int i = 0; i < itemAmount; i++)
            {
                Console.WriteLine("Select an item to add to the cart: ");
                Console.WriteLine("1. Shirt - $25.00");
                Console.WriteLine("2. Jeans - $50.00");
                Console.WriteLine("3. Shoes - $75.00");
                Console.Write("Enter your choice (1 - 3): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cart[i] = 1;
                        Console.WriteLine("Shirt added to cart.");
                        totalPrice += 25.00;
                        break;
                    case 2:
                        cart[i] = 2;
                        Console.WriteLine("Jeans added to cart.");
                        totalPrice += 50.00;
                        break;
                    case 3:
                        cart[i] = 3;
                        Console.WriteLine("Shoes added to cart.");
                        totalPrice += 75.00;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid item.");
                        i -= 1;
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Items in your cart:");
            foreach (int i in cart)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Shirt -  $25.00");
                        break;
                    case 2:
                        Console.WriteLine("Jeans - $50.00");
                        break;
                    case 3:
                        Console.WriteLine("Shoes - $75.00");
                        break;
                }
            }
            Console.WriteLine("Total Price: $" + totalPrice);
        }
    }
}